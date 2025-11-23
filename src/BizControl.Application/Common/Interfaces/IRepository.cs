using BizControl.Domain.Common;

namespace BizControl.Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(long id);
        Task<List<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
