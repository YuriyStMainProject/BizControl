using BizControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BizControl.Infrastructure.Persistence
{
    public class BizControlDbContext : DbContext
    {
        public BizControlDbContext(DbContextOptions<BizControlDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
