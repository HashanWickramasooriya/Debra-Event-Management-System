namespace DebraEventManagementAPi.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string? TicketType { get; set; } = "Normal";
        public decimal TicketPrice { get; set; }
        public bool IsSold { get; set; } = false;
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
