using Microsoft.Extensions.Options;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        private const string collectionName = "Events";
        public EventRepository() : base(collectionName)
        {

        }
    }
}
