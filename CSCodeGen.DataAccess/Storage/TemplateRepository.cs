
using CSCodeGen.DataAccess.Helper;
using CSCodeGen.Model.Args;
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
        public void Save(TemplateEventArgs args)
        {
            if (!_templates.Contains(args.Template))
            {
                _templates.Add(args.Template);
            }

            string savePath = string.Empty;
            if (args.fullPath == string.Empty)
            {
                savePath = GetTemplatePath(args.Template.Name);
            }
            else
            {
                savePath = args.fullPath;
            }
                
            try
            {
                args.Template.AcceptChanges();
                XMLHelper.SerializeToXml(args.Template, savePath);
                
            }
            catch (Exception ex)
            {
                args.Template.MarkAsChanged();
            }
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
            var args = new TemplateEventArgs();

           foreach (var template in _templates)
           {
                args.Template = template;
                Save(args);
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
        public Template GetTemplateByFileName(string filename)
        {
            return _templates.FirstOrDefault(t => t.FileName == filename);
        }
        public Template GetTemplateByName(string name)
        {
            return _templates.FirstOrDefault(t => t.Name == name);
        }
        public bool FileExists(string name)
        {
          return File.Exists(GetTemplatePath(name));
        }
        #endregion
    }
}












