using CSCodeGen.DataAccess.Model.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace CSCodeGen.DataAccess.Model
{
    public class XmlStorage
    {
        private readonly string _FolderPath;


        public XmlStorage(string FolderPath)
        {
            _FolderPath = FolderPath;
            Directory.CreateDirectory(_FolderPath);
        }

        #region Save & Load
        // Save
        public void SaveTemplate(Template template)
        {
            if (!template.IsChanged) return;

            try
            {
                // Falls sich der Name geändert hat, alte Datei löschen
                if (!string.IsNullOrEmpty(template.OldName) && template.OldName != template.FileName)
                {
                    string oldFilePath = Path.Combine(_FolderPath, template.OldName + ".xml");
                    if (File.Exists(oldFilePath))
                    {
                        File.Delete(oldFilePath);
                    }
                }

                // Neues XML speichern
                string newFilePath = Path.Combine(_FolderPath, template.FileName + ".xml");
                SerializeToXml(template, newFilePath);

                // Erfolgreich gespeichert → Status zurücksetzen
                template.OldName = template.FileName;
                template.IsChanged = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Speichern der Datei '{template.FileName}': {ex.Message}");
                template.IsChanged = true; // Falls Fehler auftritt, bleibt es "geändert"
            }
        }

        public void SaveAllTemplates(BindingList<Template> templates)
        {
            foreach (var template in templates.Where(t => t.IsChanged))
            {
                SaveTemplate(template);
            }
        }

        public List<string> GetDefaultKeywords()
        {
          return typeof(DefaultKeyword)
               .GetProperties(BindingFlags.Public | BindingFlags.Instance)
               .Where(prop => prop.PropertyType == typeof(string))
               .Select(prop => prop.GetValue(Configuration.Keywords)?.ToString())
               .Where(value => !string.IsNullOrEmpty(value))
               .ToList();
        }
        public BindingList<Keyword> LoadAllKeywords()
        {
            return new BindingList<Keyword>(
             GetDefaultKeywords().Select(text => new Keyword(text)).ToList()
             );
        }
        // Load
        public BindingList<Template> LoadAllTemplates()
        {
            BindingList<Template> templates = new BindingList<Template>();
            string[] files = Directory.GetFiles(_FolderPath, "*.xml");

            foreach (string file in files)
            {
                try
                {
                    Template template = DeserializeFromXml<Template>(file);
                    if (template != null)
                    {
                        template.OldName = template.FileName; // Speichert den alten Namen
                        template.IsChanged = false; // Direkt nach dem Laden als unverändert setzen
                        templates.Add(template);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Laden der Datei '{file}': {ex.Message}");
                }
            }

            return templates;
        }
        #endregion

        #region Serialize & Deserialize
        private static T DeserializeFromXml<T>(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Deserialisieren: {ex.Message}");
                return default;
            }
        }

        private static void SerializeToXml<T>(T obj, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Serialisieren: {ex.Message}");
            }
        }
        #endregion
    }
}
