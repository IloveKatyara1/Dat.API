using DAT.API.Core.DTOs;
using DAT.API.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DAT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _productService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                return Ok(await _productService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> UpdateOrInsert(ProductDto product)
        {
            try
            {
                return Ok(await _productService.UpdateOrInsert(product));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteById(Guid id)
        {
            try
            {
                return Ok(await _productService.DeleteById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
