using AutoMapper;
using BizControl.Application.Common.Interfaces;
using BizControl.Domain.Common;

namespace BizControl.Application.Common.Services
{
    public class CrudService<TEntity, TReadDto, TCreateDto, TUpdateDto> : ICrudService<TEntity, TReadDto, TCreateDto, TUpdateDto> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repo;
        private readonly IMapper _mapper;

        public CrudService(IRepository<TEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<TReadDto>> GetAllAsync()
        {
            var entities = await _repo.GetAllAsync();
            return _mapper.Map<List<TReadDto>>(entities);
        }

        public async Task<TReadDto?> GetByIdAsync(long id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity is null)
                return default;

            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<TReadDto> CreateAsync(TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repo.AddAsync(entity);
            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<TReadDto?> UpdateAsync(long id, TUpdateDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity is null)
                return default;

            _mapper.Map(dto, entity);
            await _repo.UpdateAsync(entity);

            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity is null)
                return false;

            await _repo.DeleteAsync(entity);
            return true;
        }
    }
}
