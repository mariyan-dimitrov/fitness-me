using FitnessMe_15118078.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessMe_15118078.Data
{
    public class FitnessMeDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public FitnessMeDbContext(DbContextOptions<FitnessMeDbContext> options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("15118078");
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<Weight> Weight { get; set; }
    }
}
