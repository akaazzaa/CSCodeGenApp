
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Args;
using System;
using CSCodeGen.Model.Interfaces;
using CSCodeGen.Model.Interfaces.View;
using System.IO;


namespace CSCodeGen.Library.Controller
{
    public class TemplateController
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        IRepository<Template> _repository;
        ICodeTemplateView _templateView;
        
        public TemplateController(IRepository<Template> templateStorage, ICodeTemplateView templateView)
        {
            _repository = templateStorage;
            _templateView = templateView;
            
            _templateView.LoadTemplates += OnLoadTemplates;
            _templateView.SaveTemplate += OnSaveTemplate;
            _templateView.NewTemplate += OnNewTemplate;
            _templateView.AddKeyword += OnAddKeyword;
            _templateView.RemoveKeyword += OnRemoveKeyword;
            _templateView.SaveAll += OnSaveAll;
            _templateView.DeleteKeyword += OnDeleteTemplate;
            
            
        }
        private void OnDeleteTemplate(object sender, TemplateEventArgs args)
        {
            if (args.Template == null) {return; }
            _repository.GetData().Remove(args.Template);
            _repository.Delete(args.Template.Name);
        }
        private void OnSaveAll(object sender, EventArgs e)
        {
            _repository.SaveAll();
        }    
        private void OnRemoveKeyword(object sender, TemplateEventArgs args)
        {
            if (args.Template == null || args.Keyword == null) 
            {
                _templateView.ShowMessage("Fehler: Kein Template oder Keyword ausgewählt.");
                return; 
            }

            if (args.Template.Textbausteine.Contains(args.Keyword))
            {
                args.Template.Textbausteine.Remove(args.Keyword);
                args.Template.MarkAsChanged();
            }
        }
        private void OnAddKeyword(object sender, TemplateEventArgs args)
        {
            if (args.Template == null)
            {
                _templateView.ShowMessage("Fehler: Kein Template ausgewählt, um ein Keyword hinzuzufügen.");
                return;
            }
            var keyword = new Textbaustein();
            args.Template.Textbausteine.Add(keyword);
            args.Template.MarkAsChanged();

            _templateView.ShowMessage($"Keyword wurde zum Template '{args.Template.Name}' hinzugefügt!");

        }
        private void OnNewTemplate(object sender, TemplateEventArgs args)
        {
            
            if (args.Template == null)
            {
                _templateView.ShowMessage("Fehler: Kein gültiges Template angegeben.");
                _logger.Error("Template ist null");
                return;
            }

            _repository.Add(args.Template);
            _templateView.ShowMessage($"Neues Template '{args.Template.Name}' wurde angelegt!");
            _logger.Info($"{args.Template.Name}' wurde angelegt!");
            _templateView.ShowTemplates(_repository.GetData());
        }
        private void OnSaveTemplate(object sender, TemplateEventArgs args)
        {
            if (args.Template == null)
            {
                _templateView.ShowMessage("Fehler: Kein Template zum Speichern ausgewählt.");
                _logger.Info($"Fehler: Kein Template zum Speichern ausgewählt. Template war Null");
                return;
            }
            if (!args.Template.IsChanged) { return; }

            

            if (_repository.FileExists(args.Template.Name) )
            {
                if (_templateView.ShowMessagBox($"Template '{args.Template.Name}' existiert bereits. Möchten Sie es überschreiben?", "Template existiert bereits")) 
                {
                    _repository.Save(args);
                }
                else
                {
                    var fullPath =_templateView.UseFileDialog();
                    args.fullPath = fullPath;
                    _repository.Save(args);
                    _repository.LoadAll();
                }
            }
            else
            {
                _repository.Save(args);
                _templateView.ShowMessage($"Template: {args.Template.Name} wurde gespeichert");
            }
        }
        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _repository.LoadAll();
            var templates = _repository.GetData();

            if (templates == null || templates.Count == 0)
            {
                _templateView.ShowMessage("Es sind keine Templates vorhanden.");
                _logger.Info("Keine Templates vorhanden");
            }
            _templateView.ShowTemplates(templates);
        }

    }
}
