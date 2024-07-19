using Microsoft.AspNetCore.Mvc;

namespace qrmenuproject.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
