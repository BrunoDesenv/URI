using System.Collections.Generic;

namespace URI.WebAPI.Model
{
    public class Wish : ModelBase
    {
        public string Item { get; set; }
        public string Details { get; set; }
        public byte[] PhotoFile { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
