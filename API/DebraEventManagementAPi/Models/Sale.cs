namespace DebraEventManagementAPi.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Commission { get; set; }
    }
}
