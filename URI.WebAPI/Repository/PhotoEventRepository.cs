using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class PhotoEventRepository : BaseRepository<Photo>, IPhotoEventRepository
    {
        private const string collectionName = "PhotoEvent";

        public PhotoEventRepository() : base(collectionName)
        {

        }
    }
}
