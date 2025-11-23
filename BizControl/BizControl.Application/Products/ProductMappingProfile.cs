using AutoMapper;
using BizControl.Application.Products.Dto;
using BizControl.Domain.Entities;

namespace BizControl.Application.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<CreateProductDto, Product>();

            CreateMap<UpdateProductDto, Product>();
        }
    }
}
