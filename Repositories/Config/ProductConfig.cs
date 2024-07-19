using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ProductId = 1, ProductName = "Ice Latte", ProductDescription = "Soguk latte kahvesi.", ProductPrice = 85, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 1, ProductShowcase = true },

                new Product { ProductId = 2, ProductName = "Ice Americano", ProductDescription = "Soguk americano kahvesi.", ProductPrice = 70, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 1, ProductShowcase = true },

                new Product { ProductId = 3, ProductName = "Cool Lime", ProductDescription = "Soguk Nane ve lime aromali icecek.", ProductPrice = 100, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 3, ProductShowcase = true },

                new Product { ProductId = 4, ProductName = "Ice Mocha", ProductDescription = "Soguk mocha kahvesi.", ProductPrice = 85, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 1, ProductShowcase = true },

                new Product { ProductId = 5, ProductName = "Berry Lime", ProductDescription = "Soguk bogurtlenli ve limonlu icecek.", ProductPrice = 100, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 3, ProductShowcase = true },

                new Product { ProductId = 6, ProductName = "Brownie", ProductDescription = "Çikolatalı yumusak kek.", ProductPrice = 70, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 6, ProductShowcase = true },

                new Product { ProductId = 7, ProductName = "Pumpkin Spice Latte", ProductDescription = "Bal kabağı aromalı latte kahvesi.", ProductPrice = 70, ProductImage = "/MenuProductImageFiles/IceCoffe1.jpg", CategoryId = 6, ProductShowcase = true }
            );
        }
    }
}
