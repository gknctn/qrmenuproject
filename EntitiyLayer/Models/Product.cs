using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public String? ProductImage { get; set; }
        public DateTime ProductDateCreated { get; set; }
        public bool ProductShowcase { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
