using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IServiceManager _manager;

        public ContactController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid) 
            {
                _manager.ContactService.AddContact(contact, false);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
