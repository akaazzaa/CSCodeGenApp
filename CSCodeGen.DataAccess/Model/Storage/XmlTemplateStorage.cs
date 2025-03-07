using CSCodeGen.DataAccess.Interface;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.DataAccess.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CSCodeGen.DataAccess.Model.Storage
{
    public class XmlTemplateStorage : ITemplateStorage
    {
        private readonly string _folderPath;
        private BindingList<CodeTemplate> _templates;

        public XmlTemplateStorage(string folderPath, BindingList<CodeTemplate> templates)
        {
            _folderPath = folderPath;
            _templates = templates;
            // Stelle sicher, dass der Ordner existiert
            Directory.CreateDirectory(folderPath);
        }

        public BindingList<CodeTemplate> GetTemplates()
        {
            LoadAll();


            return _templates;
        }

        #region Save & Load
        //// Save
        public void Save(CodeTemplate template)
        {
            if (!template.IsChanged) return;

            try
            {
                // Falls sich der Name geändert hat, alte Datei löschen
                if (!string.IsNullOrEmpty(template.OldName) && template.OldName != template.FileName)
                {
                    string oldFilePath = Path.Combine(_folderPath, template.OldName + ".xml");
                    if (File.Exists(oldFilePath))
                    {
                        File.Delete(oldFilePath);
                    }
                }

                // Neues XML speichern
                string newFilePath = Path.Combine(_folderPath, template.FileName + ".xml");
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
        public IEnumerable<Keyword> GetDefaultKeywords()
        {
            return new BindingList<Keyword>
          {
                new Keyword
                {
                    Id = 100,
                    Name = Configuration.Keywords.Classname,
                    PrefixWithComment = false,
                },
                new Keyword
                {
                    Id = 200,
                    Name = Configuration.Keywords.Propertie,
                    PrefixWithComment = false,
                },
                new Keyword
                {
                    Id = 300,
                    Name = Configuration.Keywords.Namespace,
                    PrefixWithComment = false,
                },
                new Keyword
                {
                    Id = 400,
                    Name = Configuration.Keywords.Variable,
                    PrefixWithComment = false,
                },
          };
        }

    }
}
