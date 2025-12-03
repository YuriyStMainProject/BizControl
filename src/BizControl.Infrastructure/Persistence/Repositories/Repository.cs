using BizControl.Application.Common.Interfaces;
using BizControl.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace BizControl.Infrastructure.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly BizControlDbContext _db;

        public Repository(BizControlDbContext db) => _db = db;

        public async Task<TEntity?> GetByIdAsync(long id) => await _db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<TEntity>> GetAllAsync() => await _db.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task AddAsync(TEntity entity)
        {
            await _db.Set<TEntity>().AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
