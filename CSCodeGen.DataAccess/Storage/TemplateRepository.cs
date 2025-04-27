
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
using System.Threading.Tasks;
using System.Xml.Serialization;
using NLog;


namespace CSCodeGen.DataAccess.Model.Storage
{
    public class TemplateRepository : IRepository<Template>
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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
                logger.Error($"[ERROR] Fehler beim Speichern: {ex.Message}");
                template.MarkAsChanged();
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
            var files = Directory.GetFiles(_folderPath, "*.xml");
            Parallel.ForEach(files, file =>
            {
                try
                {
                    var template = XMLHelper.DeserializeFromXml<Template>(file);
                    if (template != null)
                    {
                        template.OldName = template.Name;
                        template.AcceptChanges();
                        _templates.Add(template);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex, $"Fehler beim Laden der Datei {file}");
                }
            });
        }

        #endregion
    }
}












