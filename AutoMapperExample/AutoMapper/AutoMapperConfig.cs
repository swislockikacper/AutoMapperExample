using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;

namespace AutoMapperExample.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void CreateMappings()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.ProductPrice)));
        }
    }
}