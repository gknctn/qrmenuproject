using Microsoft.AspNetCore.Mvc;

namespace qrmenuproject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
