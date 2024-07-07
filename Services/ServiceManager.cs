using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IContactService _contactService;
        private readonly IAboutService _aboutService;
        private readonly ICafeContactInfoService _cafeContactInfoService;

        public ServiceManager(IProductService productService, ICategoryService categoryService, IContactService contactService, IAboutService aboutService, ICafeContactInfoService cafeContactInfoService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _contactService = contactService;
            _aboutService = aboutService;
            _cafeContactInfoService = cafeContactInfoService;
        }

        public IProductService ProductService => _productService;
        public ICategoryService CategoryService => _categoryService;
        public IContactService ContactService => _contactService;
        public IAboutService AboutService => _aboutService;
        public ICafeContactInfoService CafeContactInfoService => _cafeContactInfoService;
    }
}
