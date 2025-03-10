

using CSCodeGen.DataAccess.Model.Storage;
using CSCodeGen.Model;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Main;
using System.IO;
using System.Linq;

namespace CSCodeGen.Library.Controller
{
    public class ClassController
    {
        
        IClassRepository _classRepository;
        ITemplateRepository _templateRepository;
        IClassView _view;


        public ClassController(IClassRepository classRepository, ITemplateRepository templateRepository,IClassView classView)
        {
            _classRepository = classRepository;
            _templateRepository = templateRepository;
            _view = classView;
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

