using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProductRepository:IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        IQueryable<Product> GetShowcaseProducts(bool trackChanges);
        IQueryable<Product> GetAllProductsWithCategory(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        IQueryable<Product> GetLastThreeProduct(bool trackChanges);
        void AddProduct(Product product, bool trackChanges);
        void EditProduct(Product product, bool trackChanges);
        void DeleteProduct(Product product, bool trackChanges);
    }
}
