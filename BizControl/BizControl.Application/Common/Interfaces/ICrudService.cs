using BizControl.Domain.Common;

namespace BizControl.Application.Common.Interfaces
{
    public interface ICrudService<TEntity, TReadDto, TCreateDto, TUpdateDto> where TEntity : BaseEntity
    {
        Task<List<TReadDto>> GetAllAsync();
        Task<TReadDto?> GetByIdAsync(long id);
        Task<TReadDto> CreateAsync(TCreateDto dto);
        Task<TReadDto?> UpdateAsync(long id, TUpdateDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
