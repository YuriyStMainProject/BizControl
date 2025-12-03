using BizControl.Api.Controllers.Base;
using BizControl.Application.Common.Interfaces;
using BizControl.Application.Contracts.ProductGroups.Dto;
using BizControl.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BizControl.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductGroupsController : CrudController<ProductGroup, ProductGroupDto, CreateProductGroupDto, UpdateProductGroupDto>
    {
        public ProductGroupsController(ICrudService<ProductGroup, ProductGroupDto, CreateProductGroupDto, UpdateProductGroupDto> service) : base(service)
        {
        }
    }
}
