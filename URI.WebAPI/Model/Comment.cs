namespace URI.WebAPI.Model
{
    public class Comment : ModelBase
    {
        public User User { get; set; }
        public string Text { get; set; }
        public int Authorization { get; set; }

        public Comment(User user, string text, int authorization)
        {
            User = user;
            Text = text;
            Authorization = authorization;
        }
    }
}
