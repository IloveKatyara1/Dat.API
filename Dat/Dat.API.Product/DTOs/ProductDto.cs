namespace Dat.API.ProductAPI.DTOs
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int LeftItems { get; set; }
    }
}
