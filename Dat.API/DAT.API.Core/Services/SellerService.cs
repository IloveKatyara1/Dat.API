using AutoMapper;
using DAT.API.Core.DTOs;
using DAT.API.Core.Interfaces;
using DAT.API.DAL.Context;
using DAT.API.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAT.API.Core.Services
{
    public class SellerService : ISellerService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        //private readonly

        public SellerService(AppDbContext db, IMapper mapper
            //, IProductService productService
            )
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> DeleteById(Guid id)
        {
            var model = await _db.Sellers.FirstOrDefaultAsync(x => x.Id == id);

            if (model == null)
                return false;


            _db.Sellers.Remove(model);



            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<List<SellerDto>> GetAll()
        {
            var models = await _db.Sellers.ToListAsync();

            return _mapper.Map<List<SellerDto>>(models);
        }

        public async Task<SellerDto> GetById(Guid id)
        {
            var model = await _db.Sellers.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<SellerDto>(model);
        }

        public async Task<SellerDto> UpdateOrInsert(SellerDto seller)
        {
            var model = _mapper.Map<Seller>(seller);

            if (seller.Id != Guid.Empty || seller.Id == null)
            {
                model.Id = Guid.NewGuid();
                _db.Sellers.Add(model);
            }
            else
            {
                _db.Sellers.Update(model);
            }


            await _db.SaveChangesAsync();

            return _mapper.Map<SellerDto>(model);
        }
    }
}
