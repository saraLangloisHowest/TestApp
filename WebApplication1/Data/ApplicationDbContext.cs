using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Entities;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        private IWebHostEnvironment _env;

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IWebHostEnvironment env) : base(options)
        {
            _env = env;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasKey(u => u.Id);
            Seeder seeder = new Seeder(modelBuilder, _env);
            seeder.Seed();

        }
    }
}
