
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Data
{
    public class AppDbContext : DbContext // Explicitly specify the namespace
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
