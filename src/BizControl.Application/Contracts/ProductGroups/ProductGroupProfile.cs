using AutoMapper;
using BizControl.Application.Contracts.ProductGroups.Dto;
using BizControl.Domain.Entities;

namespace BizControl.Application.Contracts.ProductGroups
{
    public class ProductGroupProfile : Profile
    {
        public ProductGroupProfile()
        {
            CreateMap<ProductGroup, ProductGroupDto>();
            CreateMap<CreateProductGroupDto, ProductGroup>();
            CreateMap<UpdateProductGroupDto, ProductGroup>();
        }
    }
}
