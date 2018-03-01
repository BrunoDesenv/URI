namespace URI.WebAPI.Model
{
    public class UserRatingEvent : ModelBase
    {
        public User User { get; set; }
        public Event Event { get; set; }
        public int Rating { get; set; }
        public string Item { get; set; }
        public string Text { get; set; }

        public UserRatingEvent(User user, Event events, int rating, string item, string text)
        {
            User = user;
            Event = events;
            Rating = rating;
            Item = item;
            Text = text;
        }    
    }
}
