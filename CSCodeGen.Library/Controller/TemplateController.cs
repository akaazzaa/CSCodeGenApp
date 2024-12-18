using CSCodeGen.Library.Klassen.Template;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CSCodeGen.Library.Controller
{

    public class TemplateController
    {


        public TemplateController()
        {



        }

        private static string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        private const string dataName = "Templates.json";

        private const string FilePath = "C:\\Users\\danny.hausmann\\Source\\Repos\\akaazzaa\\CSCodeGenApp\\CSCodeGenApp\\Templates\\json1.json";

        private static string GetDataPath()
        {
            var path = Path.Combine(dataPath, dataName);
            return path;
        }

        public void SaveTemplates(List<Template> templates)
        {
            var json = JsonConvert.SerializeObject(templates);
            File.WriteAllText(GetDataPath(), json);
        }

        public List<Template> LoadTemplates()
        {
            if (!File.Exists(GetDataPath())) return new List<Template>();
            var json = File.ReadAllText(GetDataPath());
            return JsonConvert.DeserializeObject<List<Template>>(json);
        }

    }




}

