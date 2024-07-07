using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Components
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public CategoryListViewComponent(IServiceManager serviceManager)
        {
            _manager = serviceManager;
        }
        public IViewComponentResult Invoke()
        {
            IQueryable<Category> values = _manager.CategoryService.GetAllCategories(false);
            return View(values);
        }
    }
}
