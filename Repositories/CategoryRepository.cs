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
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void AddCategory(Category category, bool trackChanges) => AddItem(category,trackChanges);

        public Category CategoryWithProducts(int id, bool trackChanges)=>GetAll(false).Include(p => p.Products).Where(x=>x.CategoryId==id).First();

        public void DeleteCategory(Category category, bool trackChanges) => DeleteItem(category, trackChanges);

        public void EditCategory(Category category, bool trackChanges)=>EditItem(category, trackChanges);

        public IQueryable<Category> GetAllCategories(bool trackChanges) => GetAll(trackChanges);

        public Category? GetOneCategory(int id, bool trackChanges) => GetByCondition(p => p.CategoryId == id, trackChanges);
    }
}
