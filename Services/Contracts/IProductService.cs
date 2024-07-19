using Entities.Dtos;
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
        IQueryable<Product> GetShowcaseProducts(bool trackChanges);
        IEnumerable<Product> GetAllProductsWithCategory(bool trackChanges);
        IQueryable<Product> GetLastThreeProduct(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        void AddProduct(ProductDtoForInsertion productDto, bool trackChanges);
        void EditProduct(ProductDtoForUpdate productDtoForUpdate, bool trackChanges);
        void DeleteProduct(Product product, bool trackChanges);
        
        //for update
        ProductDtoForUpdate? GetOneProductForUpdate(int id, bool trackChanges);


    }
}
