using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URI.WebAPI.Model;

namespace URI.WebAPI.Repository.Interface
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllNotes();
        Task<Event> GetEvent(string id);

        // add new note document
        Task AddEvent(Event item);

        // remove a single document / note
        Task<bool> RemoveEvent(string id);

        // update just a single document / note
        Task<bool> UpdateEvent(string id, string body);

        // should be used with high cautious, only in relation with demo setup
        Task<bool> RemoveAllEvent();
    }
}
