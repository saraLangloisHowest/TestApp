using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Entities;
using WepApplication1.Data;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        private IWebHostEnvironment _env;

        public ApplicationDbContext(DbContextOptions options, IWebHostEnvironment env) : base(options)
        {
            _env = env;
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Guidance> Guidances { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Maturity> Maturities { get; set; }
        public DbSet<MaturityLevel> MaturityLevels { get; set; }
        //public DbSet<Translation> Translations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>()
                 .HasKey(s => new { s.RequirementId, s.AssessmentId });

            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.User)
                .WithMany(u => u.AssessmentsAsUser)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.Assessor)
                .WithMany(u => u.AssessmentsAsAssessor)
                .HasForeignKey(a => a.AssessorId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
            Seeder.Seed(modelBuilder, _env);
        }
    }
}
