using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace DebraEventManagementAPi.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public string? EventName { get; set; }

        public DateTime EventDate { get; set; }

        public string? EventLocation { get; set; }

        public int PartnerId { get; set; }
    }
}
