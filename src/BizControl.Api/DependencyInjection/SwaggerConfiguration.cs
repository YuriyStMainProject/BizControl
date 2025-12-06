using Microsoft.OpenApi;

namespace BizControl.Api.DependencyInjection
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddSwaggerDocs(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "BizControl API",
                    Version = "1.0.0"
                });

                var apiXml = Path.Combine(AppContext.BaseDirectory, "BizControl.Api.xml");
                options.IncludeXmlComments(apiXml, includeControllerXmlComments: true);

                var appXml = Path.Combine(AppContext.BaseDirectory, "BizControl.Application.xml");
                options.IncludeXmlComments(appXml);
            });

            return services;
        }
    }
}
