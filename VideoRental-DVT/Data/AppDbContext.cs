using VideoRental_DVT.Models;
using Microsoft.EntityFrameworkCore;

namespace VideoRental_DVT.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Video> Videos  { get; set; }
        public DbSet<Customer> Customers  { get; set; }


    }
}
