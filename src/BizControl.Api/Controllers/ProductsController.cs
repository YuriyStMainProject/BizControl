using BizControl.Application.Products;
using BizControl.Application.Products.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BizControl.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductDto>> Get(long id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item is null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> Create(CreateProductDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id:long}")]
        public async Task<ActionResult<ProductDto>> Update(long id, UpdateProductDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (updated is null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete(long id)
        {
            var ok = await _service.DeleteAsync(id);
            if (!ok)
                return NotFound();

            return NoContent();
        }
    }

}
