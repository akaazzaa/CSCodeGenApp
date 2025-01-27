using CSCodeGen.DataAccess.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CSCodeGen.DataAccess.Repository
{
    public class TemplateRepossitory : IRepository<Template>
    {
        public List<Template> dataList => throw new System.NotImplementedException();

        public string filePath => throw new System.NotImplementedException();

        public void Add(Template item)
        {
            dataList.Add(item);
        }

        public List<Template> GetAll()
        {
            return dataList;
        }

        public void LoadDataFromJson()
        {

           

            var templates = JsonConvert.DeserializeObject<List<Template>>(File.ReadAllText(Const.GetFullPath()));

            if (templates == null || templates.Count == 0)
            {
                return new List<Template>();
            }

            return templates;
        }

        public void Remove(Template item)
        {
            throw new System.NotImplementedException();
        }

        public void Save(List<Template> templates)
        {
            var json = JsonConvert.SerializeObject(templates);
            File.WriteAllText(Const.GetFullPath(), json);
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
