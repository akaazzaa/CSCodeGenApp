using CSCodeGen.DataAccess.Model.Main;
using System.Collections.Generic;

namespace CSCodeGen.DataAccess.Interface
{
    public interface ITemplateStorage
    {
        void Save(CodeTemplate template);
        void SaveAll(IEnumerable<CodeTemplate> templates);
        IEnumerable<CodeTemplate> LoadAll();
    }
}
