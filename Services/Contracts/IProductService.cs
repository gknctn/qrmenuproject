using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetAllProductsWithCategory(bool trackChanges);
        IQueryable<Product> GetLastThreeProduct(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        void AddProduct(Product product, bool trackChanges);
        void EditProduct(Product product, bool trackChanges);
        void DeleteProduct(Product product, bool trackChanges);

    }
}
