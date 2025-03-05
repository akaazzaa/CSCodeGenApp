using CSCodeGen.DataAccess.Interface;
using CSCodeGen.DataAccess.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Library.Controller
{
    public class TemplateController
    {
        private BindingList<CodeTemplate> templates;
        private CodeTemplate currentTemplate;
        public BindingList<CodeTemplate> Templates { get; private set; } = new BindingList<CodeTemplate>();

        private readonly ITemplateStorage _templateStorage;

        public TemplateController(ITemplateStorage templateStorage)
        {
            _templateStorage = templateStorage;
            // Direkt beim Erstellen Templates laden
            LoadAllTemplates();
        }

        #region Laden und Speichern 
        public void SaveAllTemplates()
        {
            _templateStorage.SaveAll(Templates);
        }
        public void LoadAllTemplates()
        {
            Templates.Clear();
            foreach (var template in _templateStorage.LoadAll())
            {
                Templates.Add(template);
            }
        }

        #endregion
    }
}
