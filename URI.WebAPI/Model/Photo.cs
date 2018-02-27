using System.Collections.Generic;

namespace URI.WebAPI.Model
{
    public class Photo : ModelBase
    {
        public User User { get; set; }
        public UserPhone UserPhone { get; set; }
        public int PhotoFile { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Authorization { get; set; }
        public List<Comment> Comments { get; set; }

        public Photo(User user, UserPhone userPhone, int photoFile, string title, string text, int authorization, List<Comment> comments)
        {
            User = user; UserPhone = userPhone; PhotoFile = photoFile; Title = title; Text = text; Authorization = authorization; Comments = comments;
        }
    }
}
