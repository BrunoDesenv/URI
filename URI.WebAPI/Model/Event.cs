using System;
using System.Collections.Generic;

namespace URI.WebAPI.Model
{
    public class Event : ModelBase
    {
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
        public List<User> Users { get; set; }
        public List<Wish> Wishs { get; set; }
        public List<Video> Videos { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
