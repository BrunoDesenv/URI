namespace URI.WebAPI.Model
{
    public class Invited : ModelBase
    {
        public Event Event { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Classification { get; set; }
  
    }
}
