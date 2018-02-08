using Microsoft.Extensions.Options;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private const string colletionName = "User";

        public UserRepository() : base(colletionName)
        {

        }
    }
}
