using AutoMapper;
using BizControl.Application.Contracts.Products.Dto;
using BizControl.Domain.Entities;

namespace BizControl.Application.Contracts.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
