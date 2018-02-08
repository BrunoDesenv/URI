using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var lista = _repository.GetAll();
            return lista;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(Guid id)
        {
            return _repository.GetById(id);
        }
        
        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody]User item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = Guid.NewGuid();

            _repository.Add(item);
            return Accepted();
        }
        
        // PUT: api/User/5
        [HttpPut("{user}")]
        public void Put(int id, [FromBody]User item)
        {
            _repository.Update(item);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
