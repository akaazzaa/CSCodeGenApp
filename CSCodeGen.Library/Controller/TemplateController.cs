using CSCodeGen.Library.Klassen;
using CSCodeGen.Library.Klassen.Template;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CSCodeGen.Library.Controller
{

    public class TemplateController
    {
        private readonly string templateDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        private readonly TemplatePlaceholder placeholders;

        private static TemplateController _instance;
        private BindingList<Template> templates;


        public static TemplateController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TemplateController();
                }
                return _instance;
            }

        }

        private TemplateController()
        {
            LoadTemplates();
            this.placeholders = new TemplatePlaceholder();
        }

        public void Add(Template template)
        {
            templates.Add(template);
        }

        public BindingList<Template> GetTemplates()
        {
            return templates;
        }

        private string GetDataPath()
        {
            var path = Path.Combine(templateDirectory, "Templates.json");
            return path;
        }

        public void SaveTemplates()
        {
            var json = JsonConvert.SerializeObject(templates);
            File.WriteAllText(GetDataPath(), json);
        }

        private void LoadTemplates()
        {
            if (!File.Exists(GetDataPath())) templates = new BindingList<Template>();
            var json = File.ReadAllText(GetDataPath());
            templates = JsonConvert.DeserializeObject<BindingList<Template>>(json);
        }

        public Template GetTemplate(int selectedIndex)
        {
            if (selectedIndex == -1) { return null; }
            return templates[selectedIndex];
        }
        public string FillTemplate(string template)
        {
            return placeholders.ReplacePlaceholders(template);
        }

        public void AddPlaceholder(string key, string value)
        {
            placeholders.AddPlaceholder(key, value);
        }

        public void RemovePlaceholder(string key)
        {
            placeholders.RemovePlaceholder(key);
        }

        public Dictionary<string, string> GetPlaceholders()
        {
            return placeholders.GetPlaceholders();
        }
    }




}

