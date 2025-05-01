using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Text;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace CSCodeGen.Library.Controller
{
    public class GenerateController
    {
        //IRepository<Result> _resultRepository;
        IRepository<Template> _templateRepository;
        IClassView _view;

        private string _ClassName;
        private string _NameSpace;

        public GenerateController(IRepository<Template> templateRepo, IClassView classView)
        {
            _templateRepository = templateRepo;
            _view = classView;
            _view.LoadTemplates += OnLoadTemplates;
            _view.GenerateCode += OnGenerateCode;
            _view.Save += OnSave;
        }


        #region Events
        private void OnSave(object sender, GeneratorEventArgs args)
        {
            File.WriteAllText(args.SavePath,args.ContentResult);
        }
        private void OnGenerateCode(object sender, GeneratorEventArgs args)
        {
            _ClassName = args.ClassName;
            _NameSpace = args.Namespace;

            string ret = ReplaceUserValuesInTemplate(args);

            if (ret == null)
            {
                return;
            }
            
            ;
            _view.ShowText(ret);
        }
        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _templateRepository.LoadAll();
            _view.Show(_templateRepository.GetData());
        }
        #endregion
        #region Methods
        /// <summary>
        /// Baut den CSharpCode zusammen.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private string ReplaceUserValuesInTemplate(GeneratorEventArgs args)
        {
            if (args.UserValues == null || string.IsNullOrEmpty(args.TemplateName))
            {
                return null;
            }

            Template template = _templateRepository.GetTemplateByName(args.TemplateName);

            args.ContentResult = template.Content;

            foreach (var userValue in args.UserValues)
            {
                if (string.IsNullOrEmpty(userValue.Value)) { continue; }

                var matchingTextbaustein = template.Textbausteine.Where(tb => tb.Type == userValue.Type).ToList();

                foreach (var textbaustein in matchingTextbaustein)
                {
                    string replacedCode = ReplaceDefaultString(textbaustein.Code, userValue);
                    args.ContentResult = args.ContentResult.Replace(textbaustein.DisplayText, replacedCode + "\r\r" + "            " + textbaustein.DisplayText);
                }
            }

            return ReplaceDefaultString(args.ContentResult);
        }
        /// <summary>
        ///  Ersetz die Standartwerte mit den User eingaben
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="userValue"></param>
        /// <returns></returns>
        private string ReplaceDefaultString(string ret, UserValue userValue = null)
        {
            if (ret == null) { return string.Empty; }

            foreach (Textbaustein textbaustein in ConfigData.GetDefaults())
            {
                switch (textbaustein.Name)
                {
                    case DefaultText.PREFABCLASSNAME:
                        ret = ret.Replace(textbaustein.DisplayText, _ClassName);
                        break;
                    case DefaultText.PREFABNAMESPACE:
                        ret = ret.Replace(textbaustein.DisplayText, _NameSpace);
                        break;
                    case DefaultText.PREFABVARNAME:
                        if (userValue != null && !string.IsNullOrEmpty(userValue.Value))
                        {
                            ret = ret.Replace(textbaustein.DisplayText, PropertyNameToVariable(userValue.Value));
                        }
                        break;
                    default:
                        if (userValue != null && !string.IsNullOrEmpty(userValue.Value))
                        {
                            ret = ret.Replace(textbaustein.DisplayText,userValue.Value);
                        }
                        break;
                }
            }
            return ret;
        }
        /// <summary>
        /// Macht einen Propertynamen zu einem Variablennamen.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string PropertyNameToVariable(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return $"{name.Substring(0, 1).ToLower()}{name.Substring(1, checked(name.Length - 1))}";
        }
        #endregion

    }

}

