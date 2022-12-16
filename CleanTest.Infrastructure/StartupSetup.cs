using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CleanTest.Infrastructure.Data;

namespace CleanTest.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddCatalogDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<CatalogDbContext>(options =>
                options.UseSqlServer(connectionString)); // will be created in web project root

        //add other dbContext ...
    }
}