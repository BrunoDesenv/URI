namespace URI.WebAPI.Model
{
    public class PhotoEventComment : ModelBase
    {
        public PhotoEvent PhotoEvent { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public int Authorization { get; set; }
    }
}
