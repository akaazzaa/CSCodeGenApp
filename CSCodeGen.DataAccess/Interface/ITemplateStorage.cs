using CSCodeGen.DataAccess.Model.Main;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSCodeGen.DataAccess.Interface
{
    public interface ITemplateStorage
    {
        BindingList<CodeTemplate> GetTemplates();
        void Save(CodeTemplate template);
        void SaveAll();
        void LoadAll();
    }
}
