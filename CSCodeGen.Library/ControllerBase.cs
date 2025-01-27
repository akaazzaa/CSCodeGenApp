using CSCodeGen.DataAccess.Repository;
using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public abstract class ControllerBase<T> 
    {
        protected readonly IRepository<T> repository;

        public ControllerBase(IRepository<T> repository)
        {
           this.repository = repository;
        }

        public virtual void Add(T item)
        {
            repository.Add(item);
        }

        public virtual void Remove(T item)
        {
            repository.Remove(item);
        }

        public virtual List<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}