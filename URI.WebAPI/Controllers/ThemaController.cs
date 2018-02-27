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
    [Route("api/Thema")]
    public class ThemaController : Controller
    {
        private readonly IThemaRepository _repository;

        public ThemaController(IThemaRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IEnumerable<Thema> Get()
        {
            var lista = _repository.GetAll();
            return lista;
        }

        // GET: api/Thema/5
        [HttpGet("{id}")]
        public Thema Get(Guid id)
        {
            return _repository.GetById(id);
        }
        
        // POST: api/Thema
        [HttpPost]
        public IActionResult Post([FromBody]Thema item)
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
