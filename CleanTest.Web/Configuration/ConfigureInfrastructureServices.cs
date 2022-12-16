using CleanTest.Infrastructure.Data;
using CleanTest.SharedKernel.Interfaces;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureInfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //if you dont use Infrastructure config, config yourself here otherwise leave empty

            return services;
        }
    }
}
