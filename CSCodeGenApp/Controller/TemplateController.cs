using CSCodeGenApp.Klassen;
using CSCodeGenApp.Klassen.Template;
using Newtonsoft.Json;

namespace CSCodeGenApp.Controller
{

    public class TemplateController
    {
       

        public TemplateController()
        {
          


        }

        public Template CreateNew()
        {
            return new Template();
        }
        private const string FilePath = "C:\\Users\\danny.hausmann\\Source\\Repos\\akaazzaa\\CSCodeGenApp\\CSCodeGenApp\\Templates\\json1.json";

        public void SaveTemplates(List<Template> templates)
        {
            var json = JsonConvert.SerializeObject(templates);
            File.WriteAllText(FilePath, json);
        }

        public List<Template> LoadTemplates()
        {
            if (!File.Exists(FilePath)) return new List<Template>();
            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Template>>(json);
        }

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

