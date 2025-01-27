using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess.Repository
{
    public interface IRepository<T>
    {
        List<T> dataList { get;  }
         string filePath { get; }
         void LoadDataFromJson();

        List<T> GetAll();

        void Save();

        void Remove(T item);

        void Add(T item);
        
    }
}
