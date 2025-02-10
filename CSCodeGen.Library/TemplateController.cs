

using CSCodeGen.DataAccess;
using CSCodeGen.DataAccess.Model;
using System.ComponentModel;


namespace CSCodeGen.Library
{
    public class TemplateController
    {
        IDataStorage<Template> _storage;
        BindingList<Template> _templates = new BindingList<Template>();

        public TemplateController(IDataStorage<Template> dataStorage)
        {
            _storage = dataStorage;

            if (_storage != null)
            {
                _templates = _storage.LoadData();
            }

        }

        public BindingList<Template> GetTemplateList()
        {
            return _templates;
        }
        public void Add(Template template)
        {
            _templates.Add(template);
        }

        public void Remove(Template template)
        {
            _templates.Remove(template);
        }

        public void Save()
        {
            _storage.SaveData(_templates);
        }

    }
}
