namespace URI.WebAPI.Model
{
    public class Invited : ModelBase
    {
        public Event Event { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Classification { get; set; }

        public Invited(Event events, string name, string phone, string email, int classification)
        {
            Event = events;
            Name = name;
            Phone = phone;
            Email = email;
            Classification = classification;
        }
  
    }
}
