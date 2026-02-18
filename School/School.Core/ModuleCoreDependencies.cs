using Microsoft.Extensions.DependencyInjection;
using School.Core.Features.Students.Queries.Handlers;
using School.Core.Features.Students.Queries.Models;
using System.Reflection;

namespace School.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
