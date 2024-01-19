using AutoMapper;
using Dat.API.DAL.Models;
using Dat.API.ProductAPI.DTOs;

namespace BinanceCoupons.API
{
    public static class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() =>
            new (confg =>
            {
                confg.CreateMap<Product, ProductDto>().ReverseMap();
            });
    }
}
