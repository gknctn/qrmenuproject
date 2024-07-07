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
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void AddCategory(Category category, bool trackChanges)
        {
            _manager.Category.AddItem(category,trackChanges);
            _manager.save();
        }

        public Category CategoryWithProducts(int id, bool trackChanges)
        {
            return _manager.Category.CategoryWithProducts(id,trackChanges);
        }

        public void DeleteCategory(Category category, bool trackChanges)
        {
            _manager.Category.DeleteItem(category,trackChanges);
            _manager.save();
        }

        public void EditCategory(Category category, bool trackChanges)
        {
            _manager.Category.EditItem(category,trackChanges);
            _manager.save();
        }

        public IQueryable<Category> GetAllCategories(bool trackChanges)
        {
            return _manager.Category.GetAllCategories(trackChanges);
        }

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            return _manager.Category.GetOneCategory(id,trackChanges);
        }
    }
}
