using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventRepository _repository;

        public EventsController(IEventRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// List all Users.
        /// </summary>
        // GET api/Event
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            var lista = _repository.GetAll();
            return lista;
        }

        /// <summary>
        /// Lista User by id
        /// </summary>
        /// <param name="id">id type GUID (required).</param>
        // GET api/Event/5
        [HttpGet("{id}")]
        public Event Get(Guid id)
        {
            return _repository.GetById(id);
        }


        /// <summary>
        /// Creates a User.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Event
        ///     {
        ///     }
        ///
        /// </remarks>
        /// <param name="user"></param>
        /// <returns>A newly-created Event</returns>
        /// <response code="201">Returns the newly-created Event</response>
        /// <response code="400">If the Event is null</response>           
        [HttpPost]
        public IActionResult Post([FromBody]Event item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = Guid.NewGuid();

            _repository.Add(item);
            return Accepted();
        }

        // PUT api/Event/5
        [HttpPut("{user}")]
        public void Put([FromBody]Event item)
        {
            _repository.Update(item);
        }

        /// <summary>
        /// Deletes a specific Event.
        /// </summary>
        /// <param name="id"> Id Type GUID</param>    
        // DELETE api/Event/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}