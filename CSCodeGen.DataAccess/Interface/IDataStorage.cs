using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess
{
    public interface IDataStorage<T>
    {
        List<T> LoadData();
        void SaveData(List<T> data);
    }
}
