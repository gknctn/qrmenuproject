using Entities.Models;

namespace qrmenuproject.Models
{
    public class CategoryWithProducts
    {
        public List<Category>? Categories { get; set; }
        public IOrderedEnumerable<Product>? Products { get; set; }
    }
}
