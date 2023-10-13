using AutoMapper;
using Dat.ProductAPI.Models;

namespace Dat.ProductAPI
{
	public  static class MappingConfig
	{
		public static MapperConfiguration RegisterMap() =>
			new MapperConfiguration(cnfg => cnfg.CreateMap<ProductDto, Product>().ReverseMap());
		
	}
}
