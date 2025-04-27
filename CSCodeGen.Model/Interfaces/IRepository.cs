using CSCodeGen.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Model.Interfaces
{
    public interface  IRepository<T>
    {
        BindingList<T> GetData();
        void Add(T obj);
        void Save(T obj);
        void SaveAll();
        void LoadAll();
        void Delete(string filePath);
       
    }
}
