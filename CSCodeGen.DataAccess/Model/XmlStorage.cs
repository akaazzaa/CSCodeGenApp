using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSCodeGen.DataAccess.Model
{
    public class XmlStorage<T> : IDataStorage<T>
    {
        private readonly string _filePath;

        public XmlStorage(string filePath)
        {
            _filePath = filePath;
        }

        public BindingList<T> LoadData()
        {
            if (!File.Exists(_filePath))
                return new BindingList<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamReader reader = new StreamReader(_filePath))
            {
                List<T> list = (List<T>)serializer.Deserialize(reader) ?? new List<T>();
                return new BindingList<T>(list);
            }
        }

        public void SaveData(BindingList<T> data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
