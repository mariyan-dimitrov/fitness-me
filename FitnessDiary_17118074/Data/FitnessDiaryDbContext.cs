using FitnessDiary_17118074.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiary_17118074.Data
{
    public class FitnessDiaryDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public FitnessDiaryDbContext(DbContextOptions<FitnessDiaryDbContext> options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("17118074");
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<Weight> Weight { get; set; }
    }
}
