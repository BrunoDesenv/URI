using System.Collections.Generic;

namespace URI.WebAPI.Model
{
    public class Video : ModelBase
    {
        public User User { get; set; }
        public UserPhone UserPhone { get; set; }
        public string VideoFile { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Authorization { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(User user, UserPhone userPhone, string videoFile, string title, string text, int authorization, List<Comment> comments)
        {
            User = user;
            UserPhone = userPhone;
            VideoFile = videoFile;
            Title = title;
            Text = text;
            Authorization = authorization;
            Comments = comments;
        }
    }
}
