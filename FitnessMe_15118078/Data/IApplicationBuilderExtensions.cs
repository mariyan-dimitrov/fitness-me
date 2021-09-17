using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using FitnessMe_15118078.Common;
using FitnessMe_15118078.Data.Models;

namespace FitnessMe_15118078.Data
{
    public static class IApplicationBuilderExtensions
    {
        public static void EnsureIdentityDbIsCreated(this IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var dbContext = services.GetRequiredService<FitnessMeDbContext>();

                // Ensure the database is created.
                // Note this does not use migrations. If database may be updated using migrations, use DbContext.Database.Migrate() instead.
                dbContext.Database.EnsureCreated();
            }
        }

        public static async Task SeedAdminAndRolesAsync(this IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.Administrator));
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.BasicUser));

                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

                string adminUserEmail = "admin@admin.com";
                string adminUserPassword = "123456";
                var adminUser = new IdentityUser
                {
                    UserName = adminUserEmail,
                    Email = adminUserEmail,
                    EmailConfirmed = true,
                };

                await userManager.CreateAsync(adminUser, adminUserPassword);
                await userManager.AddToRoleAsync(adminUser, Constants.Roles.Administrator);

                var context = services.GetRequiredService<FitnessMeDbContext>();
                var food = new Food
                {
                    Name = "Apple",
                    Protein = 3,
                    Carbs = 14,
                    Fats = 0,
                    Calories = 104,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };

                context.Food.Add(food);

                var meal = new Meal
                {
                    Food = food,
                    FoodId = food.Id,
                    UserId = adminUser.Id,
                    IdentityUser = adminUser,
                    Portion = 2,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                context.Meal.Add(meal);

                var weight = new Weight()
                {
                    UserId = adminUser.Id,
                    IdentityUser = adminUser,
                    Mass = 80,
                    Day = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                context.Weight.Add(weight);

                var workout = new Workout()
                {
                    UserId = adminUser.Id,
                    IdentityUser = adminUser,
                    CategoryId = 1,
                    Distance = 10,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                context.Workouts.Add(workout);

                await context.SaveChangesAsync();
            }
        }
    }
}
