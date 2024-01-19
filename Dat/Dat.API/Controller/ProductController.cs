using Dat.API.DAL.Models;
using Dat.API.ProductAPI.DTOs;
using Dat.API.ProductAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dat.API.Controller
{
    [ApiController]
    [Route("/Api/Product")]
    public class ProductController : ControllerBase
    {
        private ProductService _productService { get; set; }

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("")]
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            try
            {
                var products = await _productService.GetAll(); 
                return products;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> GetById(Guid id)
        {
            try
            {
                var product = await _productService.GetById(id);
                return product;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("")]
        public async Task<ProductDto> Insert([FromBody] ProductDto product)
        {
            try
            {
                var res = await _productService.Insert(product);
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteById(Guid id)
        {
            try
            {
                var res = await _productService.Delete(id);
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPut("")]
        public async Task<ProductDto> Put([FromBody] ProductDto product)
        {
            try
            {
                var res = await _productService.Put(product);
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
