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
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.PremiumUser));
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.BasicUser));

                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

                string adminUserEmail = "a@a.com";
                string adminUserPassword = "123456";
                var adminUser = new IdentityUser
                {
                    UserName = adminUserEmail,
                    Email = adminUserEmail,
                    EmailConfirmed = true,
                };

                string premiumUserEmail = "p@p.com";
                string premiumUserPassword = "123456";
                var premiumUser = new IdentityUser
                {
                    UserName = premiumUserEmail,
                    Email = premiumUserEmail,
                    EmailConfirmed = true,
                };

                string basicUserEmail = "b@b.com";
                string basicUserPassword = "123456";
                var basicUser = new IdentityUser
                {
                    UserName = basicUserEmail,
                    Email = basicUserEmail,
                    EmailConfirmed = true,
                };

                await userManager.CreateAsync(adminUser, adminUserPassword);
                await userManager.AddToRoleAsync(adminUser, Constants.Roles.Administrator);
                
                await userManager.CreateAsync(premiumUser, premiumUserPassword);
                await userManager.AddToRoleAsync(premiumUser, Constants.Roles.PremiumUser);

                await userManager.CreateAsync(basicUser, basicUserPassword);
                await userManager.AddToRoleAsync(basicUser, Constants.Roles.BasicUser);
                var context = services.GetRequiredService<FitnessMeDbContext>();
               
                var apple = new Food
                {
                    Name = "Apple",
                    Protein = 3,
                    Carbs = 14,
                    Fats = 1,
                    Calories = 104,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var banana = new Food
                {
                    Name = "Banana",
                    Protein = 2,
                    Carbs = 93,
                    Fats = 3,
                    Calories = 163,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var egg = new Food
                {
                    Name = "Egg",
                    Protein = 36,
                    Carbs = 2,
                    Fats = 62,
                    Calories = 214,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var chicken = new Food
                {
                    Name = "Chicken",
                    Protein = 80,
                    Carbs = 4,
                    Fats = 16,
                    Calories = 176,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var lettuce = new Food
                {
                    Name = "Lettuce",
                    Protein = 30,
                    Carbs = 63,
                    Fats = 7,
                    Calories = 7,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };

                context.Food.Add(apple);
                context.Food.Add(banana);
                context.Food.Add(egg);
                context.Food.Add(chicken);
                context.Food.Add(lettuce);

                var firstAdminMeal = new Meal
                {
                    Food = apple,
                    FoodId = apple.Id,
                    UserId = adminUser.Id,
                    IdentityUser = adminUser,
                    Portion = 1,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var secondAdminMeal = new Meal
                {
                    Food = chicken,
                    FoodId = chicken.Id,
                    UserId = adminUser.Id,
                    IdentityUser = adminUser,
                    Portion = 2,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var firstPremiumUserMeal = new Meal
                {
                    Food = chicken,
                    FoodId = chicken.Id,
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Portion = 3,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var secondPremiumUserMeal = new Meal
                {
                    Food = egg,
                    FoodId = egg.Id,
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Portion = 3,
                    Date = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
              
                context.Meal.Add(firstAdminMeal);
                context.Meal.Add(secondAdminMeal);
                context.Meal.Add(firstPremiumUserMeal);
                context.Meal.Add(secondPremiumUserMeal);

                var weight1 = new Weight()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Mass = 80,
                    Day = DateTime.UtcNow,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var weight2 = new Weight()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Mass = 90,
                    Day = DateTime.Now.AddDays(1).ToUniversalTime(),
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var weight3 = new Weight()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Mass = 95,
                    Day = DateTime.Now.AddDays(2).ToUniversalTime(),
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var weight4 = new Weight()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    Mass = 90,
                    Day = DateTime.Now.AddDays(3).ToUniversalTime(),
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };

                context.Weight.Add(weight1);
                context.Weight.Add(weight2);
                context.Weight.Add(weight3);
                context.Weight.Add(weight4);

                var workout1 = new Workout()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    CategoryId = 1,
                    Distance = 10,
                    Date = DateTime.Now,
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var workout2 = new Workout()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    CategoryId = 1,
                    Distance = 15,
                    Date = DateTime.Now.AddDays(1).ToUniversalTime(),
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };
                var workout3 = new Workout()
                {
                    UserId = premiumUser.Id,
                    IdentityUser = premiumUser,
                    CategoryId = 1,
                    Distance = 12,
                    Date = DateTime.Now.AddDays(2).ToUniversalTime(),
                    CreatedAt_15118078 = DateTime.UtcNow,
                    UpdatedAt_15118078 = DateTime.UtcNow
                };

                context.Workouts.Add(workout1);
                context.Workouts.Add(workout2);
                context.Workouts.Add(workout3);

                await context.SaveChangesAsync();
            }
        }
    }
}
