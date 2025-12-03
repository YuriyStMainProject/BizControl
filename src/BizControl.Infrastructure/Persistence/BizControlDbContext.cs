using BizControl.Domain.Entities;
using BizControl.Infrastructure.Data.Conventions;
using Microsoft.EntityFrameworkCore;

namespace BizControl.Infrastructure.Persistence
{
    public class BizControlDbContext : DbContext
    {
        public BizControlDbContext(DbContextOptions<BizControlDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            HierarchyConvention.Apply(modelBuilder); // створюєм зв'зок між дочірньою та батьківською групами в таблиці груп
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products => Set<Product>();
    }
}
