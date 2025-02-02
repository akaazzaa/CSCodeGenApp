using CSCodeGen.DataAccess.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CSCodeGen.DataAccess.Repository
{
    public class TemplateRepossitory : RepositoryBase<Template>
    {
        public TemplateRepossitory(IDataStorage<Template> dataStorage) : base(dataStorage)
        {
        }
    }
}
