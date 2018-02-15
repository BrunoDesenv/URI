using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/PhotoEventComment")]
    public class PhotoEventCommentController : Controller
    {
        private readonly IPhotoEventCommentRepository _repository;

        public PhotoEventCommentController(IPhotoEventCommentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<PhotoEventComment> Get()
        {
            var lista = _repository.GetAll();
            return lista;
        }

        // GET: api/PhotoEventComment/5
        [HttpGet("{id}", Name = "Get")]
        public PhotoEventComment Get(Guid id)
        {
            return _repository.GetById(id);
        }
        
        // POST: api/PhotoEventComment
        [HttpPost]
        public IActionResult Post([FromBody]PhotoEventComment item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = Guid.NewGuid();

            _repository.Add(item);
            return Accepted();
        }
        

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid  id)
        {
            _repository.Delete(id);
        }
    }
}
