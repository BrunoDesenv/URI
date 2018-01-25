using MongoDB.Bson.Serialization.Attributes;
using System;


namespace URI.WebAPI.Model
{
    public class Event
    {
        [BsonId]
        public string Id { get; set; }
        public int IdUser { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Private { get; set; }
        public int Theme { get; set; }
        public int Abstract { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public float Latitude { get; set; }
        public int InputValue { get; set; }
        public int Consumation { get; set; }
        public int Attire { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdatedOn { get; set; }


    }
}
