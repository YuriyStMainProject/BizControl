
using BizControl.Application;
using BizControl.Infrastructure;
using BizControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BizControl.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // базові сервіси
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // підключаємо наші шари
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                try
                {
                    var db = scope.ServiceProvider.GetRequiredService<BizControlDbContext>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Migration error: " + ex.Message);
                }
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
}
