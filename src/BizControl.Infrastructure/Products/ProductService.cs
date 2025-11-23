using AutoMapper;
using BizControl.Application.Common.Interfaces;
using BizControl.Application.Common.Services;
using BizControl.Application.Products;
using BizControl.Application.Products.Dto;
using BizControl.Domain.Entities;

namespace BizControl.Infrastructure.Products
{
    public class ProductService : CrudService<Product, ProductDto, CreateProductDto, UpdateProductDto>, IProductService
    {
        public ProductService(
            IRepository<Product> repo,
            IMapper mapper)
            : base(repo, mapper)
        {
        }

        // тут можна додавати додаткові методи, якщо треба
    }
}
