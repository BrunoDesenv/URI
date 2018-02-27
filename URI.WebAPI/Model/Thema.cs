namespace URI.WebAPI.Model
{
    public class Thema : ModelBase
    {
        public User User { get; set; }
        public string Name { get; set; }
        public string BackgroundPhoto { get; set; }
        public string ColorFont { get; set; }
        public string Song { get; set; }

        public Thema(User user, string name, string backgroundPhoto, string colorFont, string song)
        {
            User = user; Name = name; BackgroundPhoto = backgroundPhoto; ColorFont = colorFont; Song = song;
        }
    }
}
