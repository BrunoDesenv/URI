using System;
using System.Collections.Generic;

namespace URI.WebAPI.Repository.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}
