using DebraEventManagementAPi.Models;
using Microsoft.EntityFrameworkCore;

namespace DebraEventManagementAPi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Partner> Partners { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .Property(s => s.Commission)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Ticket>()
                .Property(t => t.TicketPrice)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
