

using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Model;
using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using System;
using System.IO;
using System.Linq;

namespace CSCodeGen.Library.Controller
{
    public class GenerateController
    {
        
        IRepository<Result> _resultRepository;
        IRepository<Template> _templateRepository;
        IClassView _view;

        

        public GenerateController(IRepository<Result> resultRepo, IRepository<Template> templateRepo,IClassView classView)
        {
            _templateRepository = templateRepo;

            _view = classView;
            _view.LoadTemplates += OnLoadTemplates;
            _view.GenerateCode += OnGenerateCode;
        }

        private void OnGenerateCode(object sender, GeneratorEventArgs args)
        {
            string tmp =  Generate(args);
            _view.ShowText(tmp);
        }

        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _templateRepository.LoadAll();
            _view.Show(_templateRepository.GetData());
        }

        public string Generate(GeneratorEventArgs args)
        {
            string source = string.Empty;

            if (args == null) return source;

            source = args.Template.Content;

            foreach (UserValue uservalue in args.Result.userValues)
            {
                if (string.IsNullOrEmpty(uservalue.Value))
                {
                    continue;
                }

                var matching = args.Template.Textbausteine.Where(k => k.Type == uservalue.Type).ToList();

                foreach (Textbaustein platzhalter in matching)
                {

                    string code = ReplaceDefaultKeys(platzhalter.Code, uservalue);

                    source = source.Replace(platzhalter.DisplayText, code + "\r\r" + "            " + platzhalter.DisplayText);
                }
            }

            return ReplaceDefaultKeys(source);
        }

        public static string ReplaceDefaultKeys(string text, UserValue userValue = null, Result result = null)
        {
            foreach (Textbaustein Textbaustein in ConfigData.GetDefaults())
            {
                if (Textbaustein.Name == ConfigData.DefaultBaustein.Classname && result != null)
                {
                    //text = text.Replace(platzhalter.DisplayText, r.ClassName);
                }
                else if (Textbaustein.Name == ConfigData.DefaultBaustein.Namespace && result != null)
                {
                    //text = text.Replace(platzhalter.DisplayText, _context.NameSpace);
                }
                else if (Textbaustein.Name == ConfigData.DefaultBaustein.Variable)
                {
                    if (userValue != null && !string.IsNullOrEmpty(userValue.Value))
                    {
                        text = text.Replace(Textbaustein.DisplayText, PropertyNameToVariable(userValue.Value));
                    }
                }
                else if (Textbaustein.Name == ConfigData.DefaultBaustein.Propertie)
                {
                    if (userValue != null && !string.IsNullOrEmpty(userValue.Value))
                    {
                        text = text.Replace(Textbaustein.DisplayText, userValue.Value);
                    }
                }
            }

            return text;
        }

        private static string PropertyNameToVariable(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return $"{name.Substring(0, 1).ToLower()}{name.Substring(1, checked(name.Length - 1))}";
        }


        public void Save(string source)
        {
            ////string path = CoreGlobals.Instance.SaveCSPath;
            //string fileName = "NewCSDatei.cs";
            //string fullPath = Path.Combine(path, fileName);

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            //File.WriteAllText(fullPath, source);
        }




    }

}

