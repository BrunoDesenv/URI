﻿using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : ModelBase
    {
        private readonly IMongoDatabase _database = null;
        private string _collectionName;
        private const string connectionString = "mongodb://pinguim:uri+_.789654@ds257858.mlab.com:57858/heroku_rt8z6mf0";
        private const string database = "heroku_rt8z6mf0";


        public BaseRepository( string collectionName)
        {
            var client = new MongoClient(connectionString);

            if (client != null)
                _database = client.GetDatabase(database);

            _collectionName = collectionName;
        }

        void IBaseRepository<TEntity>.Add(TEntity entity)
        {
            var collection = _database.GetCollection<TEntity>(_collectionName);

            collection.InsertOne(entity);
        }

        void IBaseRepository<TEntity>.Update(TEntity entity)
        {
            var collection = _database.GetCollection<TEntity>(_collectionName);

            var filter = Builders<TEntity>.Filter.Eq("id", entity.Id);

            var UpdateAllObj = Builders<TEntity>.Update
                .Set(x => x, entity);


            collection.UpdateOne(filter, UpdateAllObj);
        }

        void IBaseRepository<TEntity>.Delete(Guid id)
        {
            var collection = _database.GetCollection<TEntity>(_collectionName);
            var filter = Builders<TEntity>.Filter.Eq("id", id);

            collection.DeleteOne(filter);
        }

        TEntity IBaseRepository<TEntity>.GetById(Guid id)
        {
            var collection = _database.GetCollection<TEntity>(_collectionName);

            var result = collection.AsQueryable().Where(x => x.Id == id);

            return result.FirstOrDefault();
        }

        IEnumerable<TEntity> IBaseRepository<TEntity>.GetAll()
        {
            var collection = _database.GetCollection<TEntity>(_collectionName);

            return collection.Find(_ => true).ToList();
        }

    }
}
