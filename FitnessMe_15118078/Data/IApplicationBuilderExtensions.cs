using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using FitnessMe_15118078.Common;

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
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.User));

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
            }
        }
    }
}
