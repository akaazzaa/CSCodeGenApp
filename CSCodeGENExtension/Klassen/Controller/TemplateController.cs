using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGENExtension.Klassen.Controller
{

    public class TemplateController
    {
        public Template CreateNew()
        {
            return new Template();
        }
        private const string FilePath = "C:\\Users\\dgami\\source\\repos\\CSCodeGenApp\\CSCodeGENExtension\\Templates\\json1.json";

        public void SaveTemplates(List<Template> templates)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(templates);
            File.WriteAllText(FilePath, json);
        }

        public  List<Template> LoadTemplates()
        {
            if (!File.Exists(FilePath)) return new List<Template>();
            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Template>>(json);
        }

        public  void AddTemplate(Template template)
        {
            var templates = LoadTemplates();
            templates.Add(template);
            SaveTemplates(templates);
        }

        public static void RemoveTemplate(string templateName)
        {
            
        }

        public static void DisplayTemplates()
        {
           
        }
        //public string GenerateCode()
        //{
        //    //StringBuilder classBuilder = new StringBuilder();
        //    //classBuilder.AppendLine("using System;");
        //    //classBuilder.AppendLine($"namespace {NamespaceName}");
        //    //classBuilder.AppendLine("{");
        //    //classBuilder.AppendLine($"    public class {ClassName}");
        //    //classBuilder.AppendLine("    {");

        //    //foreach (var prop in Properties)
        //    //{
        //    //    classBuilder.AppendLine($"        public {prop.Type} {prop.Name} {{ get; set; }}");
        //    //}

        //    //classBuilder.AppendLine("    }");
        //    //classBuilder.AppendLine("}");
        //    //return classBuilder.ToString();
        //}
    }
}
