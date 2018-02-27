namespace URI.WebAPI.Model
{
    public class UserPhone : ModelBase
    {
        public string CellPhone { get; set; }
        public int Status { get; set; }

        public UserPhone(string cellPhone, int status)
        {
            CellPhone = cellPhone; Status = status;
        }
    }
}
