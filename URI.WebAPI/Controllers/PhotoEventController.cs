using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/PhotoEvent")]
    public class PhotoEventController : Controller
    {
        private readonly IPhotoEventRepository _repository;

        public PhotoEventController(IPhotoEventRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Photo> Get()
        {
            var lista = _repository.GetAll();
            return lista;
        }

        // GET: api/PhotoEvent/5
        [HttpGet("{id}", Name = "Get")]
        public Photo Get(Guid id)
        {
            return _repository.GetById(id);
        }
        
        // POST: api/PhotoEvent
        [HttpPost]
        public IActionResult Post([FromBody]Photo item)
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
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
