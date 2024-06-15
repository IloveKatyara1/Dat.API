using DAT.API.Core.DTOs;
using DAT.API.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DAT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;
        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _sellerService.GetAll());
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
                return Ok(await _sellerService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> UpdateOrInsert(SellerDto seller)
        {
            try
            {
                return Ok(await _sellerService.UpdateOrInsert(seller));
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
                return Ok(await _sellerService.DeleteById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
