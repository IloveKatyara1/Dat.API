using Dat.ProductAPI.Models;
using System.Collections.Generic;

namespace Dat.ProductAPI.Services
{
	public interface IProductService
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(Guid id);
		Task<ProductDto> CreateOrUpdateProduct(ProductDto product);
		Task<bool> DeleteProduct(Guid id);
	}
}
