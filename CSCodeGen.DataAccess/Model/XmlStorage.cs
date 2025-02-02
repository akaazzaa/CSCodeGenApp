using System;
using System.Collections.Generic;
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

        public List<T> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamReader reader = new StreamReader(_filePath))
            {
                return (List<T>)serializer.Deserialize(reader) ?? new List<T>();
            }
        }

        public void SaveData(List<T> data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
