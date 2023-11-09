using Autofac;
using Restaurant.Core.Application.Services;
using Restaurant.Core.Application.Services.AboutService;
using Restaurant.Core.Application.Services.ProductService;
using Restaurant.Infrastructure.Persistence.Repositories;
using System.Reflection;
using System;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Core.Application.Mappings;
using Module = Autofac.Module;

namespace Restaurant.Presentation.WebAPI.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericService<,>)).As(typeof(IGenericService<,>)).InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(RestaurantDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
    