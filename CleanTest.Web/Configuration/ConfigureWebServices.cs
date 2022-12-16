using CleanTest.Web.Interfaces;
using CleanTest.Web.Services;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<ICatalogViewModelService, CatalogViewModelService>();

            //services.AddMediatR(typeof(BasketViewModelService).Assembly);
            //services.AddScoped<IBasketViewModelService, BasketViewModelService>();
            //services.AddScoped<CatalogViewModelService>();
            //services.AddScoped<ICatalogItemViewModelService, CatalogItemViewModelService>();
            //services.Configure<CatalogSettings>(configuration);
            //services.AddScoped<ICatalogViewModelService, CachedCatalogViewModelService>();

            return services;
        }
    }
}
