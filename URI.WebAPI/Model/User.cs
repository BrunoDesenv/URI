namespace URI.WebAPI.Model
{
    public class User : ModelBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public UserPhone UserPhone { get; set; }
    }
}
