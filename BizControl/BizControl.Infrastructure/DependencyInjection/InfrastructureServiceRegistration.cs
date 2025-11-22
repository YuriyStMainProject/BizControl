using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BizControl.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // var conn = configuration.GetConnectionString("Default");
            // services.AddDbContext<BizControlDbContext>(...);
            // services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
