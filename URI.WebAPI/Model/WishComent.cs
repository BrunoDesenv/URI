namespace URI.WebAPI.Model
{
    public class WishComent : ModelBase
    {
        public int Id { get; set; }
        public User User { get; set; }
        public WishComent MyProperty { get; set; }
    }
}
