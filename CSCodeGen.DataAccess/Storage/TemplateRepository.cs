
using CSCodeGen.DataAccess.Helper;
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
                XMLHelper.SerializeToXml(template, newFilePath);

                // Erfolgreich gespeichert → Status zurücksetzen
                template.OldName = template.Name;
                template.AcceptChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ERROR] Fehler beim Speichern: {ex.Message}");
                template.MarkAsChanged(); // Falls Fehler auftritt, bleibt der Status auf "geändert"
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
                    Template template = XMLHelper.DeserializeFromXml<Template>(file);
                    if (template != null)
                    {
                        template.OldName = template.Name; // Speichert den alten Namen
                        template.AcceptChanges(); // Direkt nach dem Laden als unverändert setzen
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
    }
}












