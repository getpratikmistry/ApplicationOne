using Microsoft.Extensions.DependencyInjection;
using One.Domain.Interfaces;
using One.Infrastructure.Data;
using One.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace One.Infrastructure
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddResositoryDependency(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OneDBContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Register Entity repositories
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
