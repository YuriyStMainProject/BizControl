using BizControl.Application.Common.Interfaces;
using BizControl.Application.Products.Dto;
using BizControl.Domain.Entities;

namespace BizControl.Application.Products
{
    public interface IProductService : ICrudService<Product, ProductDto, CreateProductDto, UpdateProductDto>
    {
        // тут потім можна додавати спец-методи
    }
}
