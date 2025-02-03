using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeGen.DataAccess
{
    public interface IDataStorage<T>
    {
        BindingList<T> LoadData();
        void SaveData(BindingList<T> data);
    }
}
