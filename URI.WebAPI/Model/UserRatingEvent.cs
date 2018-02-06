namespace URI.WebAPI.Model
{
    public class UserRatingEvent : ModelBase
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
        public int Rating { get; set; }
        public string Item { get; set; }
        public string Text { get; set; }
    }
}
