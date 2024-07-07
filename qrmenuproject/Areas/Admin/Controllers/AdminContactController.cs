using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminContactController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminContactController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            IQueryable<Contact> values = _manager.ContactService.GetAllContact(false);
            return View(values);
        }

        public IActionResult ContactDetail(int id)
        {
            Contact value = _manager.ContactService.GetOneContact(id, false);
            return View(value);
        }
        [HttpGet]
        public IActionResult ContactDelete(int id)
        {
            Contact? value = _manager.ContactService.GetOneContact(id, false);

            return View(value);
        }
        [HttpPost]
        public IActionResult ContactDelete(int id, Contact contact)
        {
            Contact? value = _manager.ContactService.GetOneContact(id, false);
            _manager.ContactService.DeleteContact(value, false);
            return RedirectToAction("Index");
        }
    }
}
