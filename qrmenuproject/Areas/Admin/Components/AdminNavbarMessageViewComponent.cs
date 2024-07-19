using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Areas.Admin.Components
{
    public class AdminNavbarMessageViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public AdminNavbarMessageViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            IQueryable<Contact>? value = _manager.ContactService.GetLast3Contact(false);
            return View(value);
        }
    }
}