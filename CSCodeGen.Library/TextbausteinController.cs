using CSCodeGen.DataAccess;
using CSCodeGen.DataAccess.Model;
using System.ComponentModel;

namespace CSCodeGen.Library
{
    public class TextbausteinController
    {
        IDataStorage<Textbaustein> _storage;
        BindingList<Textbaustein> _textbaustein = new BindingList<Textbaustein>();

        public TextbausteinController(IDataStorage<Textbaustein> dataStorage)
        {
            _storage = dataStorage;

            if (_storage != null)
            {
                _textbaustein = _storage.LoadData();
            }

        }

        public BindingList<Textbaustein> GetListTextbausteine()
        {
            return _textbaustein;
        }
        public void Add(Textbaustein textbaustein)
        {
            _textbaustein.Add(textbaustein);
        }

        public void Remove(Textbaustein textbaustein)
        {
            _textbaustein.Remove(textbaustein);
        }

        public void Save()
        {
            _storage.SaveData(_textbaustein);
        }
    }
}