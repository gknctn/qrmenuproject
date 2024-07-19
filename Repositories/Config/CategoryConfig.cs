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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Soğuk Kahveler" }, 
                new Category { CategoryId = 2, CategoryName = "Sıcak Kahveler" }, 
                new Category { CategoryId = 3, CategoryName = "Soğuk Içecekler" }, 
                new Category { CategoryId = 4, CategoryName = "Sıcak Içecekler" }, 
                new Category { CategoryId = 5, CategoryName = "Kutu Icecekler" }, 
                new Category { CategoryId = 6, CategoryName = "Pastalar" },
                new Category { CategoryId = 7, CategoryName = "Tatlılar" }
                );
        }
    }
}
