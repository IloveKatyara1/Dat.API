using DAT.API.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT.API.Core.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        public Task<T> UpdateOrInsert(T product);
        public Task<bool> DeleteById(Guid id);
        public Task<T> GetById(Guid id);
        public Task<List<T>> GetAll();
    }
}
