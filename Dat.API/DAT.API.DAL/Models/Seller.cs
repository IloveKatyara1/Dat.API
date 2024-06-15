using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAT.API.DAL.Models;

[Index("Id", Name = "IX_Seller_Id")]
public partial class Seller
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    [InverseProperty("Seller")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
