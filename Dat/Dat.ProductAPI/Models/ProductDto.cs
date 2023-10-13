namespace Dat.ProductAPI.Models
{
	public class ProductDto
	{
		public Guid ProductId { get; set; }

		public string ProductName { get; set; }

		public decimal Price { get; set; }

		public string ProductDescription { get; set; }

		public int AvailableItems { get; set; }
	}
}
