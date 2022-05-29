using lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace lab2.Dal
{
    public class ParkingDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
