
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Args;
using System;
using System.ComponentModel;
using CSCodeGen.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CSCodeGen.Model.Interfaces.View;


namespace CSCodeGen.Library.Controller
{
    public class TemplateController
    {
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
                args.Template.IsChanged = true;
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
            args.Template.IsChanged = true;

            _templateView.ShowMessage($"Keyword wurde zum Template '{args.Template.Name}' hinzugefügt!");

        }
        private void OnNewTemplate(object sender, TemplateEventArgs args)
        {
            
            if (args.Template == null)
            {
                _templateView.ShowMessage("Fehler: Kein gültiges Template angegeben.");
                return;
            }

            _repository.Add(args.Template);
            _templateView.ShowMessage($"Neues Template '{args.Template.Name}' wurde angelegt!");
            _templateView.ShowTemplates(_repository.GetData());
        }
        private void OnSaveTemplate(object sender, TemplateEventArgs args)
        {
            if (args.Template == null)
            {
                _templateView.ShowMessage("Fehler: Kein Template zum Speichern ausgewählt.");
                return;
            }

            if (!_repository.GetData().Contains(args.Template))
            {
                _templateView.ShowMessage("Warnung: Template existiert nicht, es wird nun hinzugefügt.");
                _repository.Add(args.Template);
            }
            else
            {
                _repository.Save(args.Template);
            }

            _templateView.ShowMessage($"Template '{args.Template.Name}' wurde gespeichert!");
        }
        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _repository.LoadAll();
            var templates = _repository.GetData();

            if (templates == null || templates.Count == 0)
            {
                _templateView.ShowMessage("Es sind keine Templates vorhanden.");
            }
            _templateView.ShowTemplates(templates);
        }

    }
}
