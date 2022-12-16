using CleanTest.Core.CatalogAggregate;
using CleanTest.Core.Interfaces;
using CleanTest.Core.Services;
using CleanTest.Infrastructure.Data;
using CleanTest.SharedKernel.Interfaces;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //if you dont use core config, config yourself here otherwise leave empty

            //services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
            //services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
            //services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            return services;
        }
    }
}
