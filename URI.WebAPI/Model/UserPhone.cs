namespace URI.WebAPI.Model
{
    public class UserPhone : ModelBase
    {
        public User User { get; set; }
        public string CellPhone { get; set; }
        public int Status { get; set; }
    }
}
