using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori adı alanı boş geçilemez.")]
        public string? CategoryName { get; set; }
        public List<Product>? Products { get; set; }
    }
}
