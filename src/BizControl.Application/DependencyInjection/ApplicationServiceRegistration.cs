using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BizControl.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(
                cfg => { },                      // пустий конфіг, нічого не робимо
                Assembly.GetExecutingAssembly()  // де лежать наші Profile
            );

            return services;
        }
    }
}