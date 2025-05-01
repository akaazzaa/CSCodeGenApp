using CSCodeGen.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Model.Interfaces
{
    public interface  IRepository<T>
    {
        BindingList<T> GetData();
        void Add(T obj);
        bool Save(T obj);
        bool FileExists(string name);
        void SaveAll();
        void LoadAll();
        void Delete(string filePath);
        Template GetTemplateByName(string name);


    }
}
