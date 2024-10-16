using DebraEventManagementAPi.Data;
using DebraEventManagementAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DebraEventManagementAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly DataContext _context;

        public SaleController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult RecordSale(SellRequest sellRequest)
        {
            var ticket = _context.Tickets
                .Include(t => t.Event)
                .FirstOrDefault(t => t.TicketId == sellRequest.TicketID);

            if (ticket == null)
            {
                return NotFound("Couldn't find the ticket.");
            }

            ticket.IsSold = true;

            var sale = new Sale
            {
                TicketId = sellRequest.TicketID,
                Ticket = ticket,
                SaleDate = DateTime.UtcNow,
                Commission = sellRequest.Commission
            };

            _context.Sales.Add(sale);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSaleById), new { id = sale.SaleId }, sale);
        }

        [HttpGet("{id}")]
        public IActionResult GetSaleById(int id)
        {
            var sale = _context.Sales
                .Include(s => s.Ticket)
                .ThenInclude(t => t.Event)
                .FirstOrDefault(s => s.SaleId == id);

            if (sale == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                sale.SaleId,
                sale.TicketId,
                sale.Ticket.TicketPrice,
                sale.Ticket.EventId,
                sale.Ticket.Event.EventName,
                sale.SaleDate,
                sale.Commission
            });
        }

        [HttpGet("partner/{PartnerId}")]
        public IActionResult GetSalesByPartner(int PartnerId)
        {
            var partnerEvents = _context.Events
                .Where(e => e.PartnerId == PartnerId)
                .Select(e => e.EventId)
                .ToList();

            var sales = _context.Sales
                .Include(s => s.Ticket)
                .ThenInclude(t => t.Event)
                .Where(s => partnerEvents.Contains(s.Ticket.EventId))
                .Select(s => new
                {
                    s.SaleId,
                    s.TicketId,
                    s.Ticket.TicketPrice,
                    s.Ticket.EventId,
                    s.Ticket.Event.EventName,
                    s.SaleDate,
                    s.Commission
                })
                .ToList();

            var groupedSales = sales
                .GroupBy(s => new { s.EventId, s.EventName })
                .Select(g => new
                {
                    EventId = g.Key.EventId,
                    EventName = g.Key.EventName,
                    TotalEarnings = g.Sum(s => s.TicketPrice - s.Commission),
                    Sales = g.ToList()
                })
                .ToList();

            return Ok(groupedSales);
        }

        [HttpGet("event/{EventId}/earnings")]
        public IActionResult GetTotalEarningsByEvent(int EventId)
        {
            var earnings = _context.Sales
                .Where(s => s.Ticket.EventId == EventId)
                .Sum(s => s.Ticket.TicketPrice - s.Commission);
            return Ok(earnings);
        }
    }

    public class SellRequest
    {
        public int TicketID { get; set; }
        public int Commission { get; set; } = 0;
    }
}
