using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAT.API.DAL.Models;

public partial class Product
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int LeftItems { get; set; }

    public string Description { get; set; } = null!;

    public Guid SellerId { get; set; }

    [ForeignKey("SellerId")]
    [InverseProperty("Products")]
    public virtual Seller Seller { get; set; } = null!;
}
