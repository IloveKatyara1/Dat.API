using AutoMapper;
using DAT.API.Core.DTOs;
using DAT.API.Core.Interfaces;
using DAT.API.DAL.Context;
using DAT.API.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAT.API.Core.Services
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

        public async Task<bool> DeleteById(Guid id)
        {
            var model = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (model == null)
                return false;


            _db.Products.Remove(model);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var models = await _db.Products.ToListAsync();

            return _mapper.Map<List<ProductDto>>(models);
        }

        public async Task<ProductDto> GetById(Guid id)
        {
            var model = await _db.Products
                .Include(x => x.Seller)
                .FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<ProductDto>(model);
        }

        public async Task<List<ProductDto>> GetBySellerId(Guid sellerId)
        {
            var models = await _db.Products.Where(p => p.SellerId == sellerId).ToListAsync();

            return _mapper.Map<List<ProductDto>>(models);
        }

        public async Task<ProductDto> UpdateOrInsert(ProductDto product)
        {
            var model = _mapper.Map<Product>(product);

            if(product.Id != Guid.Empty || product.Id == null)
            {
                model.Id = Guid.NewGuid();
                _db.Products.Add(model);
            }
            else
            {
                _db.Products.Update(model);
            }


            await _db.SaveChangesAsync();

            return _mapper.Map<ProductDto>(model);
        }
    }
}
