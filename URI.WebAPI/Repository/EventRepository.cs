using Microsoft.Extensions.Options;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        private const string COLLECTION_NAME = "Events";
        public EventRepository(IOptions<Settings> settings, string collectionName = COLLECTION_NAME) : 
                            base(settings, collectionName)
        {

        }
    }
}
