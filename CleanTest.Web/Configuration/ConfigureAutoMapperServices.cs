using AutoMapper;
using CleanTest.Web.Areas.CatalogArea;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureAutoMapperServices
    {
        public static void AddAutoMapperServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));

            services.AddAutoMapper(typeof(CatalogAreaMappingProfile));


            //var mapperConfig = new MapperConfiguration(mc =>
            //{
            //    mc.AddProfile(new CatalogAreaMappingProfile());
            //});

            //IMapper mapper = mapperConfig.CreateMapper();
            //services.AddSingleton(mapper);
        }
    }
}
