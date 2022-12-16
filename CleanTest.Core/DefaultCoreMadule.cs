using Autofac;
using CleanTest.Core.CatalogAggregate;
using CleanTest.Core.Interfaces;
using CleanTest.Core.Services;

namespace CleanTest.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UriComposer>()
                .As<IUriComposer>()
                .InstancePerLifetimeScope()
                .WithParameter("catalogSettings", new CatalogSettings());



            //builder.RegisterType<ToDoItemSearchService>()
            //    .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
