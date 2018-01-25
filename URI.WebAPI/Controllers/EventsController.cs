using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using URI.WebAPI.Model;
using URI.WebAPI.Repository.Interface;

namespace URI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }


        [HttpGet]
        public Task<IEnumerable<Event>> Get()
        {
            return GetNoteInternal();
        }

        private async Task<IEnumerable<Event>> GetNoteInternal()
        {
            return await _eventRepository.GetAllNotes();
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public Task<Event> Get(string id)
        {
            return GetNoteByIdInternal(id);
        }

        private async Task<Event> GetNoteByIdInternal(string id)
        {
            return await _eventRepository.GetEvent(id) ?? new Event();
        }

        // POST api/notes
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _eventRepository.AddEvent(new Event()
            {
                Body = value,
                AddDate = DateTime.Now,
                UpdatedOn = DateTime.Now
            });
        }

        // PUT api/notes/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value)
        {
            _eventRepository.UpdateEvent(id, value);
        }

        // DELETE api/notes/5
        public void Delete(string id)
        {
            _eventRepository.RemoveEvent(id);
        }
    }
}