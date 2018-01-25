using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        private object _context;

        public EventRepository(IOptions<Settings> settings)
        {
            _context = new BaseRepository(settings);
        }

        public async Task<IEnumerable<Event>> GetAllNotes()
        {
            try
            {
                return await _context.Events
                        .Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<Event> GetEvent(string id)
        {
            var filter = Builders<Event>.Filter.Eq("Id", id);

            try
            {
                return await _context.Events
                                .Find(filter)
                                .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task AddEvent(Event item)
        {
            try
            {
                await _context.Events.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> RemoveEvent(string id)
        {
            try
            {
                DeleteResult actionResult
                    = await _context.Events.DeleteOneAsync(
                        Builders<Event>.Filter.Eq("Id", id));

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> UpdateEvent(string id, string body)
        {
            var filter = Builders<Event>.Filter.Eq(s => s.Id, id);
            var update = Builders<Event>.Update
                            .Set(s => s.Body, body)
                            .CurrentDate(s => s.UpdatedOn);

            try
            {
                UpdateResult actionResult
                    = await _context.Events.UpdateOneAsync(filter, update);

                return actionResult.IsAcknowledged
                    && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> UpdateEvent(string id, Event item)
        {
            try
            {
                ReplaceOneResult actionResult
                    = await _context.Events
                                    .ReplaceOneAsync(n => n.Id.Equals(id)
                                            , item
                                            , new UpdateOptions { IsUpsert = true });
                return actionResult.IsAcknowledged
                    && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> RemoveAllEvent()
        {
            try
            {
                DeleteResult actionResult
                    = await _context.Events.DeleteManyAsync(new BsonDocument());

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}
