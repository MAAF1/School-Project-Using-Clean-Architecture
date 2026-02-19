using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Data;
using School.Infrastructure.InfrastructureBases;
using School.Infrastructure.Repositories;

namespace School.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDpendencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;

        }
    }
}
