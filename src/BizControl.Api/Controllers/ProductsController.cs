using BizControl.Api.Controllers.Base;
using BizControl.Application.Common.Interfaces;
using BizControl.Application.Contracts.Products.Dto;
using BizControl.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BizControl.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : CrudController<Product, ProductDto, CreateProductDto, UpdateProductDto>
    {
        public ProductsController(ICrudService<Product, ProductDto, CreateProductDto, UpdateProductDto> service) : base(service)
        {
        }
    }
}
