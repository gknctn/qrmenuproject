using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "Ürün adı boş geçilemez.")]
        public string? ProductName { get; init; }

        [Required(ErrorMessage = "Ürün açıklaması boş geçilemez.")]
        public string? ProductDescription { get; init; }

        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Ürün fiyatı pozitif bir değer olmalıdır.")]
        public decimal? ProductPrice { get; init; }

        public String? ProductImage { get; set; }

        [Required(ErrorMessage = "Kategori alanı boş geçilemez.")]
        public int CategoryId { get; init; }
    }
}
