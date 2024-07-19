using Entities.Models;
using Microsoft.EntityFrameworkCore;
using qrmenuproject.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void AddProduct(Product product, bool trackChanges) => AddItem(product, trackChanges);
        public void DeleteProduct(Product product, bool trackChanges) => DeleteItem(product, trackChanges);

        public void EditProduct(Product product, bool trackChanges) => AddItem(product, trackChanges);

        public IQueryable<Product> GetAllProducts(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<Product> GetAllProductsWithCategory(bool trackChanges) => GetAll(trackChanges).Include(x => x.Category);

        public IQueryable<Product> GetLastThreeProduct(bool trackChanges) => GetAll(trackChanges).OrderByDescending(x => x.ProductId).Take(3);

        public Product? GetOneProduct(int id, bool trackChanges) => GetByCondition(
            p => p.ProductId == id,
            trackChanges);

        public IQueryable<Product> GetShowcaseProducts(bool trackChanges) => GetAll(trackChanges).Where(x => x.ProductShowcase == true);
    }
}
