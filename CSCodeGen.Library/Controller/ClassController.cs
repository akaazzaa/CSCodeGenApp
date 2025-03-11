

using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Model;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using System;
using System.IO;
using System.Linq;

namespace CSCodeGen.Library.Controller
{
    public class ClassController
    {
        
        IRepository<Result> _resultRepository;
        IRepository<Template> _templateRepository;
        IClassView _view;


        public ClassController(IRepository<Result> resultRepo, IRepository<Template> templateRepo,IClassView classView)
        {
            _templateRepository = templateRepo;

            _view = classView;
            _view.LoadTemplates += OnLoadTemplates;
            
        }

        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _templateRepository.LoadAll();
            _view.ShowTemplates(_templateRepository.GetData());
        }

        //public string ReplaceKeywords(CodeTemplate template)
        //{
        //    string source = string.Empty;

        //    if (template == null) return source;

        //    source = template.Source;

        //    foreach (PropertyDefinition prop in _context.Properties)
        //    {
        //        if (string.IsNullOrEmpty(prop.Name) || string.IsNullOrEmpty(prop.DataType))
        //        {
        //            continue;
        //        }

        //        var matchingKeywords = template.Keywords.Where(k => k.DataType == prop.DataType).ToList();

        //        foreach (Keyword key in matchingKeywords)
        //        {

        //            string code = ReplaceDefaultKeys(key.Code, prop);

        //            source = source.Replace(key.DisplayText, code + "\r\r" + "            " + key.DisplayText);
        //        }
        //    }

        //    return ReplaceDefaultKeys(source);
        //}

        //private string ReplaceDefaultKeys(string text, PropertyDefinition prop = null)
        //{
        //    foreach (Keyword key in CoreGlobals.Instance.templateStroage.GetDefaultKeywords())
        //    {
        //        if (key.Name == Configuration.Keywords.Classname)
        //        {
        //            text = text.Replace(key.DisplayText, _context.ClassName);
        //        }
        //        else if (key.Name == Configuration.Keywords.Namespace)
        //        {
        //            text = text.Replace(key.DisplayText, _context.NameSpace);
        //        }
        //        else if (key.Name == Configuration.Keywords.Variable)
        //        {
        //            if (prop != null && !string.IsNullOrEmpty(prop.Name))
        //            {
        //                text = text.Replace(key.DisplayText, PropertyNameToVariable(prop.Name));
        //            }
        //        }
        //        else if (key.Name == Configuration.Keywords.Propertie)
        //        {
        //            if (prop != null && !string.IsNullOrEmpty(prop.Name))
        //            {
        //                text = text.Replace(key.DisplayText, prop.Name);
        //            }
        //        }
        //    }

        //    return text;
        //}

        private string PropertyNameToVariable(string name)
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

