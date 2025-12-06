using BizControl.Application.Common.Interfaces;
using BizControl.Infrastructure.Persistence;
using BizControl.Infrastructure.Persistence.Repositories;
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
                options
                .UseNpgsql(connectionString);
                // .UseSnakeCaseNamingConvention(); // нижній регістр усіх таблиць, типу OrderDetail буде виглядати як blog_post - в net 10 ше немає цього
            });

            // generic-репозиторій
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
