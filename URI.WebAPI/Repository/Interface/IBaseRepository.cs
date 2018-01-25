using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URI.WebAPI.Repository.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(string id);
        // add new note document
        Task Add(TEntity item);
        // remove a single document / note
        Task<bool> Remove(string id);
        // update just a single document / note
        Task<bool> Update(string id, string body);
        // should be used with high cautious, only in relation with demo setup
        Task<bool> RemoveAll();
    }
}
