using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAT.API.DAL.Models;

[Table("Product")]
[Index("Id", Name = "IX_Product_Id")]
public partial class Product
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int LeftItems { get; set; }

    public string Description { get; set; } = null!;
}
