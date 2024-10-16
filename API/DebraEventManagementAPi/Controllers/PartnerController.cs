using DebraEventManagementAPi.Data;
using DebraEventManagementAPi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DebraEventManagementAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly DataContext _context;

        public PartnerController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register(Partner partner)
        {
            var existingPartner = _context.Partners.FirstOrDefault(p => p.PartnerEmail == partner.PartnerEmail);
            if (existingPartner != null)
            {
                return Conflict("Email is already registered.");
            }

            _context.Partners.Add(partner);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPartner), new { id = partner.PartnerId }, partner);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            var partner = _context.Partners.SingleOrDefault(p => p.PartnerEmail == loginRequest.LoginEmail);

            if (partner == null)
            {
                return NotFound("Couldn't find a partner account for this email.");
            }

            if (partner.PartnerPassword != loginRequest.LoginPassword)
            {
                return Unauthorized("Please check your password.");
            }

            return Ok(partner);
        }

        [HttpGet("{Id}")]
        public IActionResult GetPartner(int Id)
        {
            var partner = _context.Partners.Find(Id);
            if (partner == null)
            {
                return NotFound();
            }
            return Ok(partner);
        }

       public class LoginRequest
       {
            public string? LoginEmail { get; set; }
            public string? LoginPassword { get; set; }
       }
    }
}
