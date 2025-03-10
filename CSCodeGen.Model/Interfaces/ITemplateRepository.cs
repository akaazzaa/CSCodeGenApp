using CSCodeGen.Model.Main;
using System.ComponentModel;

namespace CSCodeGen.Model.Interfaces
{
    public interface  ITemplateRepository
    {
        BindingList<Template> GetTemplates();
        void Add(Template obj);
        void Save(Template obj);
        void SaveAll();
        void LoadAll();
    }
}
