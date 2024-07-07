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

        [Required(ErrorMessage = "Ürün adı boş geçilemez.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Ürün açıklaması boş geçilemez.")]
        public string? ProductDescription { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Ürün fiyatı pozitif bir değer olmalıdır.")]
        public decimal? ProductPrice { get; set; }

        public String? ProductImage { get; set; }

        [Required(ErrorMessage = "Kategori alanı boş geçilemez.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
