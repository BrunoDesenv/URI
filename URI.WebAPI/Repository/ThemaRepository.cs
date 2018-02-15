using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class ThemaRepository : BaseRepository<Thema>, IThemaRepository
    {
        private const string collectionName = "Thema";
        public ThemaRepository() : base(collectionName)
        {

        }

    }
}
