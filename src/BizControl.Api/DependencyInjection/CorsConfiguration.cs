namespace BizControl.Api.DependencyInjection
{
    public static class CorsConfiguration
    {
        private const string ClientPolicyName = "AllowClient";

        public static IServiceCollection AddCorsPolicies(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(ClientPolicyName, policy =>
                {
                    policy.WithOrigins("http://localhost:4200") // Angular dev client
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            return services;
        }

        public static string GetClientPolicyName() => ClientPolicyName;
    }
}
