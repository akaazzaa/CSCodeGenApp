using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess.Model
{
    public class JsonStorage<T> : IDataStorage<T>
    {
        private readonly string _filePath;

        public JsonStorage(string filePath)
        {
            _filePath = filePath;
        }

        public BindingList<T> LoadData()
        {
            if (!File.Exists(_filePath))
                return new BindingList<T>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<BindingList<T>>(json) ?? new BindingList<T>();
        }

        public void SaveData(BindingList<T> data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
