
using CSCodeGen.Contracts.Interfaces;
using CSCodeGen.Model.Main;
using System;
using System.ComponentModel;

namespace CSCodeGen.Library.Controller
{
    public class TemplateController
    {
        ITemplateStorage<CodeTemplate> _storage;
        ICodeTemplateView<CodeTemplate> _view;
        public TemplateController(ITemplateStorage<CodeTemplate> templateStorage, ICodeTemplateView<CodeTemplate> view)
        {
            _storage = templateStorage;
            _view = view;

            _view.LoadTemplates += OnLoadTemplates;
            _view.SaveTemplate += OnSaveTemplate;
            _view.NewTemplate += OnNewTemplate;
            
        }

        private void OnNewTemplate(object sender, CodeTemplate template)
        {
            if (template == null) return;

            _storage.Add(template);
            _view.ShowMessage("Neues Template angelegt!");
            
        }

        private void OnSaveTemplate(object sender, CodeTemplate template)
        {
            _storage.Save(template);
            _view.ShowMessage("Template gespeichert!");
        }

        private void OnLoadTemplates(object sender, EventArgs e)
        {
            _storage.LoadAll();
            _view.ShowTemplates(_storage.GetTemplates());
        }
    }
}
