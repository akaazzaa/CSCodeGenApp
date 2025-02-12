using CSCodeGen.DataAccess.Model;
using System.ComponentModel;

namespace CSCodeGen.Library
{
    public class TemplateController
    {
        public BindingList<Template> Templates { get; private set; } = new BindingList<Template>();

        private XmlStorage _XmlStorage;

        public TemplateController(XmlStorage storage)
        {
            _XmlStorage = storage;
            LoadAllTemplates(); // Beim Erstellen des Controllers direkt die Templates laden

        }



        #region Laden und Speichern 
        public void SaveTemplate(Template template)
        {
            if (template != null && !Templates.Contains(template))
            {
                Templates.Add(template);  // Falls nicht vorhanden, hinzufügen
            }
            _XmlStorage.SaveAllTemplates(Templates);
        }
        public void LoadAllTemplates()
        {
            Templates = _XmlStorage.LoadAllTemplates();
        }
        public void SaveAllTemplates()
        {
            _XmlStorage.SaveAllTemplates(Templates);
        }
        public void DeleteTemplate(Template template)
        {
            if (template != null && Templates.Contains(template))
            {
                Templates.Remove(template);
                SaveAllTemplates(); // Aktualisierte Liste speichern
            }
        }
        #endregion
    }
}
