using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAboutController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminAboutController(IServiceManager manager)
        {
            _manager = manager;
        }

        // GET: AdminAboutController
        public ActionResult Index()
        {
            About value = _manager.AboutService.GetOneAbout(1, false);
            return View(value);
        }


        // POST: AdminAboutController/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AboutEdit(About about)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _manager.AboutService.EditAbout(about, false);
                    return RedirectToAction("Index");
                }
                else 
                {
                    return View("Index",about);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
