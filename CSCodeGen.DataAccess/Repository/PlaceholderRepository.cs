using System.Collections.Generic;
using System.IO;
using CSCodeGen.DataAccess.Model;
using Newtonsoft.Json;

namespace CSCodeGen.DataAccess.Repository
{
    public class PlaceholderRepository : IRepository<Placeholder>
    {
        public List<Placeholder> dataList { get; private set; }
        public string filePath { get; private set; }
        public PlaceholderRepository() 
        {
            LoadDataFromJson();
        }
        public List<Placeholder> GetAll()
        {
           return dataList;
        }
        public void Save()
        {
        }
        public void Remove(Placeholder item)
        {
            dataList.Remove(item);
        }
        public void Add(Placeholder item)
        {
            dataList.Add(item);
        }
        public void LoadDataFromJson()
        {
            if (!File.Exists(filePath))
            {
                UseMOKData();
                return;
            }

            var data = JsonConvert.DeserializeObject<List<Placeholder>>(File.ReadAllText(filePath));

            if (data == null)
            {
                UseMOKData();
                return;
            }
            dataList.AddRange(data);

            
        }
        public void UseMOKData()
        {
            if (dataList == null || dataList.Count == 0)
            {
                dataList = new List<Placeholder>()
                {
                     new Placeholder("namespace", "namespace <#{namespace}#>\r\n{\r\n    \r\n}"),
                     new Placeholder("Accestype", "public"),
                    new Placeholder("Type", "class"),
                     new Placeholder("classname", "MyClass"),

                     new Placeholder("Properties", "Properties"),

                    new Placeholder("methodname", "MyMethod")
                };

            }
        }
    }
}

