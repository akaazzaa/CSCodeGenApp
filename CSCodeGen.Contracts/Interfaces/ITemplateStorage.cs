using System.ComponentModel;

namespace CSCodeGen.Contracts.Interfaces
{
    public interface  ITemplateStorage<T> where T : class
    {
        T GetTemplates();
        void Add(T obj);
        void Save(T obj);
        void SaveAll();
        void LoadAll();
    }
}
