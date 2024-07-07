using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Components
{
    public class SocialMediaViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public SocialMediaViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke()
        {
            About value = _manager.AboutService.GetOneAbout(1, false);
            return View(value);
        }
    }
}
