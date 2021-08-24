using FitnessMe_15118078.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessMe_15118078.Data
{
    public class FitnessMeDbContext : IdentityDbContext
    {
        public FitnessMeDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }

        public DbSet<Meal> Meal { get; set; }

        public DbSet<Nutrition> Nutrition { get; set; }

        public DbSet<Weight> Weight { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("15118078");
        }
    }
}
