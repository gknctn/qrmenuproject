using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Controllers
{
    public class AboutController : Controller
    {
        private readonly IServiceManager _manager;

        public AboutController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            About value = _manager.AboutService.GetOneAbout(1,false);
            return View(value);
        }
    }
}
