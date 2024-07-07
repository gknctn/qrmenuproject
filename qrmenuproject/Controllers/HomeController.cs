using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using qrmenuproject.Models;
using Repositories.Contracts;
using Services.Contracts;
using System.Diagnostics;

namespace qrmenuproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceManager _manager;

        public HomeController(ILogger<HomeController> logger, IServiceManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        [HttpGet]
        public IActionResult Index([FromRoute] int id = 0)
        {
            IEnumerable<Category> categorylist = _manager.CategoryService.GetAllCategories(false);

            CategoryWithProducts values = new CategoryWithProducts();

            if (id == 0)
            {
                IEnumerable<Product> productList = _manager.ProductService.GetAllProducts(false);
                values.Products = productList.OrderBy(x => x.ProductName);
            }
            else
            {
                Category category = _manager.CategoryService.CategoryWithProducts(id, false);
                values.Products = category.Products.OrderBy(x => x.ProductName);
            }

            values.Categories = categorylist.ToList();
            return View(values);
        }
        
        public IActionResult Details([FromRoute] int id)
        {
            Product? product = _manager.ProductService.GetOneProduct(id, false);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
