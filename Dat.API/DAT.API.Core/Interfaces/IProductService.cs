using DAT.API.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT.API.Core.Interfaces
{
    public interface IProductService
    {
        public Task<ProductDto> UpdateOrInsert(ProductDto product);
        public Task<bool> DeleteById(Guid id);
        public Task<ProductDto> GetById(Guid id);
        public Task<List<ProductDto>> GetAll();
    }
}
