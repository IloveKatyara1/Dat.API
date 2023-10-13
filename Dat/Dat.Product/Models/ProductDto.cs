namespace Dat.Product.Models
{
	public class ProductDto
	{
		public int ProductId { get; set; }

		public string ProductName { get; set; }

		public decimal Price { get; set; }

		public string ProductDescription { get; set; }

		public int AvailableItems { get; set; }

		public string ProductLink { get; set; }
	}
}
