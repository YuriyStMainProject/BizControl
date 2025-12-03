using BizControl.Application.Common.Interfaces;
using BizControl.Application.Contracts.Common;
using BizControl.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace BizControl.Api.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class CrudController<TEntity, TReadDto, TCreateDto, TUpdateDto> : ControllerBase where TEntity : BaseEntity where TReadDto : IHasId
    {
        private readonly ICrudService<TEntity, TReadDto, TCreateDto, TUpdateDto> _service;

        protected CrudController(ICrudService<TEntity, TReadDto, TCreateDto, TUpdateDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<List<TReadDto>>> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id:long}")]
        public virtual async Task<ActionResult<TReadDto>> Get(long id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item is null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<ActionResult<TReadDto>> Create([FromBody] TCreateDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id:long}")]
        public virtual async Task<ActionResult<TReadDto>> Update(long id, [FromBody] TUpdateDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (updated is null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id:long}")]
        public virtual async Task<IActionResult> Delete(long id)
        {
            var ok = await _service.DeleteAsync(id);
            if (!ok)
                return NotFound();

            return NoContent();
        }
    }
}
