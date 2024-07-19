using AutoMapper;
using Entities.Dtos;
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
        private readonly IMapper _mapper;

        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
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

        public void AddProduct(ProductDtoForInsertion productDto, bool trackChanges)
        {
            Product product = _mapper.Map<Product>(productDto);

            _manager.Product.AddItem(product, trackChanges);
            _manager.save();
        }

        public void EditProduct(ProductDtoForUpdate productDtoForUpdate, bool trackChanges)
        {
            Product product = _mapper.Map<Product>(productDtoForUpdate);
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

        public ProductDtoForUpdate? GetOneProductForUpdate(int id, bool trackChanges)
        {
            Product? value = _manager.Product.GetOneProduct(id, trackChanges);
            if (value is null)
            {
                throw new Exception("Product not found");
            }
            return _mapper.Map<ProductDtoForUpdate>(value);
        }

        public IQueryable<Product> GetShowcaseProducts(bool trackChanges)
        {
            return _manager.Product.GetShowcaseProducts(trackChanges);
        }
    }
}
