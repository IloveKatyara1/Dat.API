﻿using Dat.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Dat.ProductAPI
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{

		}

        public DbSet<Product> Products { get; set; }
    }
}
