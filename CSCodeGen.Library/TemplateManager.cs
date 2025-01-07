using System;
using System.Collections.Generic;
using System.IO;

namespace CSCodeGen.Library
{
    public class TemplateManager
    {
        private readonly string _templateDirectory = "Templates";

        public TemplateManager()
        {
            // Stelle sicher, dass das Template-Verzeichnis existiert
            if (!Directory.Exists(_templateDirectory))
                Directory.CreateDirectory(_templateDirectory);
        }

        public void CreateTemplate(string templateName, List<Placeholder> placeholders)
        {
            string templatePath = Path.Combine(_templateDirectory, $"{templateName}.txt");

            using (var writer = new StreamWriter(templatePath))
            {
                foreach (var placeholder in placeholders)
                {
                    writer.WriteLine($"<#{{{placeholder.Name}}}#>");
                }
            }

            Console.WriteLine($"Template '{templateName}' wurde erstellt und gespeichert.");
        }

        public string LoadTemplate(string templateName)
        {
            string templatePath = Path.Combine(_templateDirectory, $"{templateName}.txt");
            if (!File.Exists(templatePath))
                throw new FileNotFoundException($"Template '{templateName}' wurde nicht gefunden.");

            return File.ReadAllText(templatePath);
        }

        public string FillTemplate(string templateName, Dictionary<string, string> values)
        {
            string template = LoadTemplate(templateName);

            foreach (var kvp in values)
            {
                string placeholder = $"<#{{{kvp.Key}}}#>";
                template = template.Replace(placeholder, kvp.Value);
            }

            return template;
        }
    }
}
