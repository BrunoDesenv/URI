using MongoDB.Bson.Serialization.Attributes;
using System;

namespace URI.WebAPI.Model
{
    public class User
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
