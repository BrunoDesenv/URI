namespace URI.WebAPI.Model
{
    public class VideoEventComment : ModelBase
    {
        public VideoEvent VideoEvent { get; set; }
        public string Text { get; set; }
        public int Authorization { get; set; }
    }
}
