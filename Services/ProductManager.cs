using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        IEnumerable<Product> IProductService.GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }
        public Product? GetOneProduct(int id, bool trackChanges)
        {
            Product? value = _manager.Product.GetOneProduct(id, trackChanges);
            if (value is null)
            {
                throw new Exception("Product not found");
            }
            return value;
        }

        public void AddProduct(Product product, bool trackChanges)
        {
            _manager.Product.AddItem(product, trackChanges);
            _manager.save();
        }

        public void EditProduct(Product product, bool trackChanges)
        {
            _manager.Product.EditItem(product, trackChanges);
            _manager.save();
        }

        public void DeleteProduct(Product product, bool trackChanges)
        {
            _manager.Product.DeleteItem(product, trackChanges);
            _manager.save();
        }

        public IQueryable<Product> GetLastThreeProduct(bool trackChanges)
        {
            return _manager.Product.GetLastThreeProduct(trackChanges);
        }

        public IEnumerable<Product> GetAllProductsWithCategory(bool trackChanges)
        {
            return _manager.Product.GetAllProductsWithCategory(trackChanges);
        }
    }
}
