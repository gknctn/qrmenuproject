using Microsoft.AspNetCore.Mvc;

namespace qrmenuproject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
