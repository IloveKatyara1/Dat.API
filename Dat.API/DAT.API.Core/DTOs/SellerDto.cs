using DAT.API.DAL.Models;
using System.Text.Json.Serialization;

namespace DAT.API.Core.DTOs
{
    public class SellerDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductDto> Products { get; set; } = new();
    }
}
