using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Repository
{
    public class PhotoEventCommentRepository : BaseRepository<Comment>, IPhotoEventCommentRepository
    {
        private const string colletionName = "PhotoEventComment";

        public PhotoEventCommentRepository() : base(colletionName)
        {

        }
    }
}
