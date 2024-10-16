using DebraEventManagementAPi.Data;
using DebraEventManagementAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DebraEventManagementAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SetTicketDetails(TicketRequest ticketRequest)
        {
            var @event = _context.Events.Find(ticketRequest.EventId);
            if (@event == null)
            {
                return NotFound("Event not found");
            }

            var ticket = new Ticket
            {
                TicketType = ticketRequest.TicketType,
                TicketPrice = ticketRequest.TicketPrice,
                EventId = ticketRequest.EventId,
                Event = @event 
            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetTicketsByEvent), new { eventId = ticket.EventId }, ticket);
        }

        [HttpGet("event/{EventId}")]
        public IActionResult GetTicketsByEvent(int EventId)
        {
            var tickets = _context.Tickets.Where(t => t.EventId == EventId).ToList();
            return Ok(tickets);
        }

        [HttpPost("sell/{TicketId}")]
        public IActionResult SellTicket(int TicketId)
        {
            var ticket = _context.Tickets.Find(TicketId);
            if (ticket == null)
            {
                return NotFound();
            }
            ticket.IsSold = true;
            _context.SaveChanges();
            return Ok(ticket);
        }

        [HttpGet("event/{EventId}/sold")]
        public IActionResult GetSoldTicketsByEvent(int EventId)
        {
            var soldTickets = _context.Tickets.Where(t => t.EventId == EventId && t.IsSold).ToList();
            return Ok(soldTickets);
        }
    }

    public class TicketRequest
    {
        public string TicketType { get; set; }
        public decimal TicketPrice { get; set; }
        public int EventId { get; set; }
    }
}
