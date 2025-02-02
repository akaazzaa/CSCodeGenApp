using System.Collections.Generic;
using System.IO;
using CSCodeGen.DataAccess.Model;
using Newtonsoft.Json;

namespace CSCodeGen.DataAccess.Repository
{
    public class PlaceholderRepository : RepositoryBase<Placeholder>
    {
        public PlaceholderRepository(IDataStorage<Placeholder> dataStorage) : base(dataStorage)
        {

        }
    }
}

