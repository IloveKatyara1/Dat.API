using AutoMapper;
using Dat.API.DAL;
using Dat.API.DAL.Models;
using Dat.API.ProductAPI.DTOs;
using Dat.API.Utils.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dat.API.ProductAPI.Services
{
    public class ProductService : IService<ProductDto>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public ProductService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            var model = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);

            if(model == null)
                return false;

            _db.Products.Remove(model);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var models = await _db.Products.ToListAsync();

            return _mapper.Map<IEnumerable<ProductDto>>(models);
        }

        public async Task<ProductDto> GetById(Guid id)
        {
            var model = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<ProductDto>(model);
        }

        public async Task<ProductDto> Insert(ProductDto entity)
        {
            var model = _mapper.Map<Product>(entity);

            if(model.Id == null || model.Id == Guid.Empty)
                model.Id = Guid.NewGuid();

            _db.Add(model);
            await _db.SaveChangesAsync();

            return _mapper.Map<ProductDto>(model);
        }

        public async Task<ProductDto> Put(ProductDto entity)
        {
            var model = _mapper.Map<Product>(entity);

            _db.Products.Update(model);

            await _db.SaveChangesAsync();

            return _mapper.Map<ProductDto>(model);
        }
    }
}
