using CSCodeGen.Library.Klassen.Template;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CSCodeGen.Library.Controller
{

    public class TemplateController
    {
        private static string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        private const string dataName = "Templates.json";

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
            var path = Path.Combine(dataPath, dataName);
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
            templates =  JsonConvert.DeserializeObject<BindingList<Template>>(json);
        }

        public Template GetTemplate(int selectedIndex)
        {
            if (selectedIndex == -1) { return null; }
            return templates[selectedIndex];
        }
    }




}

