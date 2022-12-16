using CleanTest.Infrastructure;
using CleanTest.Infrastructure.Data;
using CleanTest.SharedKernel.Interfaces;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureDbContextServices
    {
        public static void AddDbContextServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddCatalogDbContext(configuration.GetConnectionString("CatalogConnection"));

            //add other connections ...

        }
    }
}
