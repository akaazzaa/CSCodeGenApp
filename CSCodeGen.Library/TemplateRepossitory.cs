using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CSCodeGen.Library
{
    public class TemplateRepossitory
    {
        public List<Template> GetAllTemplates()
        {
            if (!File.Exists(Const.GetFullPath())) { return new List<Template>(); }

            var templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(Const.GetFullPath()));

            if (templates == null || templates.Count == 0)
            {
                return new List<Template>();
            }

            return templates;


        }

        public void Save(List<Template> templates)
        {
            var json = JsonConvert.SerializeObject(templates);
            File.WriteAllText(Const.GetFullPath(), json);
        }
    }
}
