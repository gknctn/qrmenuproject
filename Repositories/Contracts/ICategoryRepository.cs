using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IQueryable<Category> GetAllCategories(bool trackChanges);
        Category? GetOneCategory(int id, bool trackChanges);
        void AddCategory(Category category, bool trackChanges);
        void EditCategory(Category category, bool trackChanges);
        void DeleteCategory(Category category, bool trackChanges);
        Category CategoryWithProducts(int id, bool trackChanges);
    }
}
