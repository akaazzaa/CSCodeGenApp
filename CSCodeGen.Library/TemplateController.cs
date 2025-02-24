using CSCodeGen.DataAccess.Model;
using System.ComponentModel;

namespace CSCodeGen.Library
{
    public class TemplateController
    {
        public BindingList<Template> Templates { get; private set; } = new BindingList<Template>();
        
        private XmlStorage _xmlStorage;

        public TemplateController(XmlStorage storage)
        {
            _xmlStorage = storage;
            LoadAllTemplates(); // Direkt beim Erstellen Templates laden
        }

        #region Laden und Speichern 
        public void SaveAllTemplates()
        {
            _xmlStorage.SaveAllTemplates(Templates);
        }
        public void LoadAllTemplates()
        {
            Templates.Clear();
            foreach (var template in _xmlStorage.LoadAllTemplates())
            {
                Templates.Add(template);
            }
        }

        #endregion
    }
}
