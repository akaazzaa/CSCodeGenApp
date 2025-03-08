

using CSCodeGen.Contracts.Interfaces;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace CSCodeGen.DataAccess.Model.Storage
{
    public class XmlStorage : ITemplateStorage<CodeTemplate>
    {
        private readonly string _folderPath;
        private BindingList<CodeTemplate> _templates;

        public XmlStorage(string folderPath)
        {
            _folderPath = folderPath;
            _templates = new BindingList<CodeTemplate>();
            // Stelle sicher, dass der Ordner existiert
           
        }
        public void Add(CodeTemplate template)
        {
            _templates.Add(template);
        }
        public IEnumerable<Keyword> GetDefaultKeywords()
        {
            return new List<Keyword>
        {
            new Keyword { Id = 100, Name = Configuration.Keywords.Classname, PrefixWithComment = false },
            new Keyword { Id = 200, Name = Configuration.Keywords.Propertie, PrefixWithComment = false },
            new Keyword { Id = 300, Name = Configuration.Keywords.Namespace, PrefixWithComment = false },
            new Keyword { Id = 400, Name = Configuration.Keywords.Variable, PrefixWithComment = false }
        };
        }
        public BindingList<CodeTemplate> GetTemplates() => _templates;

        #region Save & Load
        //// Save
        public void Save(CodeTemplate template)
        {
            if (!template.IsChanged) return;

            try
            {
                string oldFilePath = Path.Combine(_folderPath, template.OldName + ".xml");
                string newFilePath = Path.Combine(_folderPath, template.Name + ".xml");

                // Falls sich der Name geändert hat, alte Datei löschen
                if (!string.IsNullOrEmpty(template.OldName) && File.Exists(oldFilePath) && oldFilePath != newFilePath)
                {
                    File.Delete(oldFilePath);
                }

                // Neues XML speichern
                SerializeToXml(template, newFilePath);

                // Erfolgreich gespeichert → Status zurücksetzen
                template.OldName = template.Name;
                template.IsChanged = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ERROR] Fehler beim Speichern: {ex.Message}");
                template.IsChanged = true; // Falls Fehler auftritt, bleibt der Status auf "geändert"
            }
        }
        public void SaveAll()
        {
            foreach (var template in _templates.Where(t => t.IsChanged))
            {
                Save(template);
            }
        }
        //// Load
        public void LoadAll()
        {
            string[] files = Directory.GetFiles(_folderPath, "*.xml");

            foreach (string file in files)
            {
                try
                {
                    CodeTemplate template = DeserializeFromXml<CodeTemplate>(file);
                    if (template != null)
                    {
                        template.OldName = template.FileName; // Speichert den alten Namen
                        template.IsChanged = false; // Direkt nach dem Laden als unverändert setzen
                        _templates.Add(template);
                    }
}
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Laden der Datei '{file}': {ex.Message}");
                }
            }
        }

        #endregion

        #region Serialize & Deserialize
        private T DeserializeFromXml<T>(string  filePath)
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

        private void SerializeToXml<T>(T obj, string filePath)
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












