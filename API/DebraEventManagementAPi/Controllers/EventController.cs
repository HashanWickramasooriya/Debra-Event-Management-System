using DebraEventManagementAPi.Data;
using DebraEventManagementAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DebraEventManagementAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateEvent(Event newEvent)
        {
            _context.Events.Add(newEvent);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEvent), new { EventId = newEvent.EventId }, newEvent);
        }

        [HttpGet("{EventId}")]
        public IActionResult GetEvent(int EventId)
        {
            var eventDetails = _context.Events.Find(EventId);
            if (eventDetails == null)
            {
                return NotFound();
            }
            return Ok(eventDetails);
        }

        [HttpGet("partner/{PartnerId}")]
        public IActionResult GetEventsByPartner(int PartnerId)
        {
            var events = _context.Events.Where(e => e.PartnerId == PartnerId).ToList();
            return Ok(events);
        }
    }
}
