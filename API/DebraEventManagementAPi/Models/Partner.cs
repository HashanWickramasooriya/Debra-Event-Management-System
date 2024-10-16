using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace DebraEventManagementAPi.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }

        public string? PartnerName { get; set; }

        public string? PartnerEmail { get; set; }

        public string? PartnerPassword { get; set; }
    }
}
