using AutoMapper;

namespace Dat.Product
{
	public static class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			new MapperConfiguration(cnfg => cnfg.CreateMap<ProductDto, Product>().ReverseMap)
		}
	}
}
