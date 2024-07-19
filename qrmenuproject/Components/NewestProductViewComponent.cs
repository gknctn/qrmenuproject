using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Components
{
    public class NewestProductViewComponent:ViewComponent
    {
        private readonly IServiceManager _manager;

        public NewestProductViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            IQueryable<Product> values = _manager.ProductService.GetShowcaseProducts(false).Take(12);
            return View(values);
        }
    }
}
