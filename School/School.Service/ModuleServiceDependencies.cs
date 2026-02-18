using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstracts;
using School.Service.Implementations;

namespace School.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDepnedencies (this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();

            return services;


        }

    }
}