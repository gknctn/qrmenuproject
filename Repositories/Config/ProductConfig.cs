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
                new Product { ProductId = 1, ProductName = "Ice Latte", ProductDescription = "Soguk latte", ProductPrice = 85, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },

                new Product { ProductId = 2, ProductName = "Ice Americano", ProductDescription = "Soguk americano", ProductPrice = 70, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },

                new Product { ProductId = 3, ProductName = "Cool Lime", ProductDescription = "Soguk Nane ve limon aromali icecek", ProductPrice = 100, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },

                new Product { ProductId = 4, ProductName = "Ice Mocha", ProductDescription = "Soguk mocha", ProductPrice = 85, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 },

                new Product { ProductId = 5, ProductName = "Berry Lime", ProductDescription = "Soguk bogurtlenli ve limonlu icecek", ProductPrice = 100, ProductImage = "~/img/bardak_cay.jpg", CategoryId = 1 }
                );
        }
    }
}
