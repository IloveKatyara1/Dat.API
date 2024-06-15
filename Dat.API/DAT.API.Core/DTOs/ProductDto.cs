using DAT.API.DAL.Models;

namespace DAT.API.Core.DTOs
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int LeftItems { get; set; }
        public Guid SellerId { get; set; }
        public virtual SellerDto? Seller { get; set; }
    }
}
