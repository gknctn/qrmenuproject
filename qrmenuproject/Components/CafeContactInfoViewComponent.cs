using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace qrmenuproject.Components
{
    public class CafeContactInfoViewComponent:ViewComponent
    {
        private readonly IServiceManager _manager;

        public CafeContactInfoViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke() 
        {
            CafeContactInfo? value = _manager.CafeContactInfoService.GetOneCafeContactInfo(1,false);
            return View(value);
        }
    }
}
