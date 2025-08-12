
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Data
{
    public class AppDbContext : DbContext // Explicitly specify the namespace
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }


        public DbSet<RegisterVM> registerUser { get; set; }
        public DbSet<UserRole> userRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure the one-to-many relationship between RegisterVM and UserRole
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.RegisterVM)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RegisterVMId);


        }
    }
}
