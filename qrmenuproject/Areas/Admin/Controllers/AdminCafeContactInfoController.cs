using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCafeContactInfoController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminCafeContactInfoController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            CafeContactInfo? value = _manager.CafeContactInfoService.GetOneCafeContactInfo(1, false);
            return View(value);
        }
        [HttpGet]
        public IActionResult CafeContactInfoEdit()
        {
            CafeContactInfo? value = _manager.CafeContactInfoService.GetOneCafeContactInfo(1, false);
            return View(value);
        }
        [HttpPost]
        public IActionResult CafeContactInfoEdit(CafeContactInfo? cafeContactInfo)
        {
            if (ModelState.IsValid)
            {
                _manager.CafeContactInfoService.EditCafeContactInfo(cafeContactInfo, false);
                return View("Index", cafeContactInfo);
            }
            return View(cafeContactInfo);
        }
    }
}
