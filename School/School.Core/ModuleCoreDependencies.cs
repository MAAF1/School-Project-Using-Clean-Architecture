using Microsoft.Extensions.DependencyInjection;
using School.Core.Features.Students.Queries.Handlers;
using School.Core.Features.Students.Queries.Models;
using System.Reflection;
using AutoMapper;


namespace School.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            // config of mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
