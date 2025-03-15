using Microsoft.Extensions.DependencyInjection;
using One.Application.Interfaces;
using One.Application.Services;

namespace One.Application
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddServiceDependency(this IServiceCollection services)
        {
            // Register Service repositories
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
