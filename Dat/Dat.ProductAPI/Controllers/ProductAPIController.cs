using Dat.ProductAPI.Models;
using Dat.ProductAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dat.ProductAPI.Controllers
{
	[Route("/products")]
	public class ProductAPIController : ControllerBase
	{
		private readonly ProductService _productService;

		public ProductAPIController(ProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<object> Get()
		{
			try
			{
				IEnumerable<ProductDto> Res = await _productService.GetProducts();

				return new ResponceDto()
				{
					IsSucces = true,
					Result = Res
				};
			}
			catch (Exception ex) 
			{
				return new ResponceDto()
				{
					IsSucces = false,
					ErrorMasegess = new List<Exception> { ex }
				};
			}
		}

		[HttpGet]
		[Route("id")]
		public async Task<object> Get(Guid id)
		{
			try
			{
				ProductDto Res = await _productService.GetProductById(id);

				return new ResponceDto()
				{
					IsSucces = true,
					Result = Res
				};
			}
			catch (Exception ex)
			{
				return new ResponceDto()
				{
					IsSucces = false,
					ErrorMasegess = new List<Exception> { ex }
				};
			}
		}

		[HttpPost]
		public async Task<object> Post([FromBody] ProductDto product)
		{
			try
			{
				ProductDto Res = await _productService.CreateOrUpdateProduct(product);

				return new ResponceDto()
				{
					IsSucces = true,
					Result = Res
				};
			}
			catch (Exception ex)
			{
				return new ResponceDto()
				{
					IsSucces = false,
					ErrorMasegess = new List<Exception> { ex }
				};
			}
		}

		[HttpPut]
		public async Task<object> Put([FromBody] ProductDto product)
		{
			try
			{
				ProductDto Res = await _productService.CreateOrUpdateProduct(product);

				return new ResponceDto()
				{
					IsSucces = true,
					Result = Res
				};
			}
			catch (Exception ex)
			{
				return new ResponceDto()
				{
					IsSucces = false,
					ErrorMasegess = new List<Exception> { ex }
				};
			}
		}

		[HttpDelete]
		[Route("id")]
		public async Task<object> Delete(Guid id)
		{
			try
			{
				bool Res = await _productService.DeleteProduct(id);

				return new ResponceDto()
				{
					IsSucces = true,
					Result = Res
				};
			}
			catch (Exception ex)
			{
				return new ResponceDto()
				{
					IsSucces = false,
					ErrorMasegess = new List<Exception> { ex }
				};
			}
		}
	}
}
