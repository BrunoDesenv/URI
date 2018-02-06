namespace URI.WebAPI.Model
{
    public class WishEvent : ModelBase
    {
        public Event Event { get; set; }
        public string Item { get; set; }
        public string Details { get; set; }
        public byte[] PhotoFile { get; set; }
    }
}
