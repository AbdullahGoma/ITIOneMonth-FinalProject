using ComeToEgypt.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectCompany.DpContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // DbContextOptions => Take Data Connection
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Information>().HasKey(am => new
            {
                am.TicketId,
                am.LocationId
            });

            modelBuilder.Entity<Information>().HasOne(m => m.Ticket).WithMany(am => am.Informations).HasForeignKey(am => am.TicketId);
            modelBuilder.Entity<Information>().HasOne(m => m.Location).WithMany(am => am.Informations).HasForeignKey(am => am.LocationId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Information> Informations { get; set; }

    }
}
