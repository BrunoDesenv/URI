using Microsoft.Extensions.Options;
using MongoDB.Driver;
using URI.WebAPI.Model;

namespace URI.WebAPI.Repository
{
    public class BaseRepository
    {
        private readonly IMongoDatabase _database = null;

        public BaseRepository(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);

            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Event> Events
        {
            get
            {
                return _database.GetCollection<Event>("Event");
            }
        }
    }
}
