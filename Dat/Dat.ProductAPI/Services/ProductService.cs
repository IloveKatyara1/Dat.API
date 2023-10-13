using AutoMapper;
using Dat.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Dat.ProductAPI.Services
{
	public class ProductService : IProductService
	{
		private readonly AppDbContext _db;
		private readonly IMapper _mapper;

		public ProductService(AppDbContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
		}

		public async Task<ProductDto> CreateOrUpdateProduct(ProductDto productDto)
		{
			Product product = _mapper.Map<Product>(productDto);

            Product existingProduct = await _db.Products.FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                _mapper.Map(productDto, existingProduct);
                _db.Products.Update(existingProduct);
            }
            else
            {
                _db.Products.Add(product);
            }


            await _db.SaveChangesAsync();

			return _mapper.Map<ProductDto>(product);
		}

		public async Task<bool> DeleteProduct(Guid id)
		{
			try
			{
				var product = await _db.Products.FirstOrDefaultAsync(product => product.ProductId == id);

				if (product == null) 
					return false;

				_db.Products.Remove(product);
				await _db.SaveChangesAsync();

				return true;
			} 
			catch 
			{
				return false;
			}
		}

		public async Task<ProductDto> GetProductById(Guid id)
		{
			Product product = await _db.Products.FirstOrDefaultAsync(product => product.ProductId == id);
			return _mapper.Map<ProductDto>(product);
		}

		public async Task<IEnumerable<ProductDto>> GetProducts()
		{
			List<Product> products = await _db.Products.ToListAsync();
			return _mapper.Map<IEnumerable<ProductDto>>(products);
		}
	}
}
