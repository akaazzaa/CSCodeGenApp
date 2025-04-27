
using CSCodeGen.DataAccess.Helper;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Main;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


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
            if (template == null) return;

            try
            {
                string filePath = GetTemplatePath(template.Name);

                // Wenn die Datei existiert, neuen Namen finden
                if (File.Exists(filePath))
                {
                    template.Name = GenerateUniqueTemplateName(template.Name);
                    filePath = GetTemplatePath(template.Name);
                }

                XMLHelper.SerializeToXml(template, filePath);

                // Synchronisieren
                template.AcceptChanges();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Fehler beim Speichern des Templates '{template?.Name}'");
                template.MarkAsChanged();
            }
        }

        private string GenerateUniqueTemplateName(string baseName)
        {
            int counter = 1;
            string newName = baseName;
            string newPath = GetTemplatePath(newName);

            
            while (File.Exists(newPath))
            {
                newName = $"{baseName}_{counter}";
                newPath = GetTemplatePath(newName);
                counter++;
            }

            return newName;

        } 

        public string GetTemplatePath(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                logger.Error("Template Name ist leer und kann nicht gespeichet werden");
                throw new ArgumentException("Template Name darf nicht leer sein.", nameof(name));
            }

            return Path.Combine(_folderPath, $"{name}.xml");
        }
        public void Delete(string name)
        {

            File.Delete(GetTemplatePath(name));
        }
        public void SaveAll()
        {
            foreach (var template in _templates.Where(t => t.IsChanged))
            {
                Save(template);
            }
        }
        public void LoadAll()
        {
            string[] files = Directory.GetFiles(_folderPath, "*.xml");

            foreach (string file in files)
            {
                try
                {
                    Template template =XMLHelper.DeserializeFromXml<Template>(file);
                    if (template != null)
                    {
                        template.OldName = template.Name; // Speichert den alten Namen
                        template.AcceptChanges(); // Direkt nach dem Laden als unverändert setzen
                        _templates.Add(template);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error($"Fehler beim Laden der Datei '{file}': {ex.Message}");
                }
            }
        }

        #endregion
    }
}












