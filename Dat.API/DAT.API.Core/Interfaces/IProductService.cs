﻿using DAT.API.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT.API.Core.Interfaces
{
    public interface IProductService : IBaseService<ProductDto>
    {
        public Task<List<ProductDto>> GetBySellerId(Guid sellerId);
    }
}
