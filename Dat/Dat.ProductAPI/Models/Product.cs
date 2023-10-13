using System.ComponentModel.DataAnnotations;

namespace Dat.ProductAPI.Models
{
	public class Product
	{
		[Key]
		public Guid ProductId { get; set; }

		[Required]
		[StringLength(255)]
		public string ProductName { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		public decimal Price { get; set; }

		[Required]
		[StringLength(1000)]
		public string ProductDescription { get; set; }

		[Required]
		[Range(0, int.MaxValue)]																																																																																																																	
		public int AvailableItems { get; set; }
	}
}