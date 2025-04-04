﻿
using CSCodeGen.Model;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace CSCodeGen.DataAccess.Model.Storage
{
    public class TemplateRepository : IRepository<Template>
    {
        private readonly string _folderPath;
        private BindingList<Template> _templates;

        public TemplateRepository(string folderPath)
        {
            _folderPath = folderPath;
            _templates = new BindingList<Template>();
            // Stelle sicher, dass der Ordner existiert
           
        }
        public BindingList<Template> GetData() => _templates;
        public void Add(Template template)
        {
            _templates.Add(template);
        }
        public IEnumerable<Textbaustein> GetDefaultKeywords()
        {
            return new List<Textbaustein>
        {
            new Textbaustein { Name = ConfigData.DefaultBaustein.Classname, PrefixWithComment = false },
            new Textbaustein { Name = ConfigData.DefaultBaustein.Propertie, PrefixWithComment = false },
            new Textbaustein { Name = ConfigData.DefaultBaustein.Namespace, PrefixWithComment = false },
            new Textbaustein { Name = ConfigData.DefaultBaustein.Variable, PrefixWithComment = false }
        };
        }    

        #region Save & Load
        //// Save
        public void Save(Template template)
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
                    Template template = DeserializeFromXml<Template>(file);
                    if (template != null)
                    {
                        template.OldName = template.Name; // Speichert den alten Namen
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

        public Template Load(string path)
        {
            throw new NotImplementedException();
        }



        #endregion

    }
}












