using Microsoft.EntityFrameworkCore;

namespace BizControl.Api.DependencyInjection
{
    public static class DatabaseMigration
    {
        public static IHost MigrateDatabase<TContext>(this IHost host)
            where TContext : DbContext
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var db = services.GetRequiredService<TContext>();
                db.Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Migration error: " + ex.Message);
                throw; // необов’язково, але корисно для контейнера
            }

            return host;
        }
    }
}
