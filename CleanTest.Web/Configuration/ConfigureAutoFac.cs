using Autofac;
using Autofac.Extensions.DependencyInjection;
using CleanTest.Core;
using CleanTest.Infrastructure;
using CleanTest.Infrastructure.Data;
using CleanTest.SharedKernel.Interfaces;

namespace CleanTest.Web.Configuration
{
    public static class ConfigureAutoFac
    {
        public static void RegisterAutoFacModules(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
            {
                containerBuilder.RegisterModule(new DefaultCoreModule());
                containerBuilder.RegisterModule(new DefaultInfrastructureModule(builder.Environment.EnvironmentName == "Development"));
            });
        }
    }
}
