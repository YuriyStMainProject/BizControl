using BizControl.Application.Common.Interfaces;
using BizControl.Application.Products;
using BizControl.Infrastructure.Persistence;
using BizControl.Infrastructure.Persistence.Repositories;
using BizControl.Infrastructure.Products;
using Microsoft.EntityFrameworkCore;
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
            var connectionString = configuration.GetConnectionString("Default");
            services.AddDbContext<BizControlDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            // generic-репозиторій
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // generic CRUD-сервіс
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
