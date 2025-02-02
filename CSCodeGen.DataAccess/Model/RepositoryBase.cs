using CSCodeGen.DataAccess.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSCodeGen.DataAccess.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        protected readonly IDataStorage<T> _dataStorage;
        protected List<T> _dataList;

        protected RepositoryBase(IDataStorage<T> dataStorage)
        {
            _dataStorage = dataStorage;
            _dataList = _dataStorage.LoadData();
        }

        public virtual List<T> GetAll() => new List<T>(_dataList);

        public virtual void Add(T item)
        {
            _dataList.Add(item);
            _dataStorage.SaveData(_dataList);
        }

        public virtual void Remove(T item)
        {
            _dataList.Remove(item);
            _dataStorage.SaveData(_dataList);
        }

        public virtual void Save() => _dataStorage.SaveData(_dataList);
    }
}