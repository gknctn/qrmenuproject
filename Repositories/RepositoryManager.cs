using qrmenuproject.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository, IContactRepository contactRepository, IAboutRepository aboutRepository, ICafeContactInfoRepository cafeContactInfoRepository) : IRepositoryManager
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly ICategoryRepository _categoryRepository = categoryRepository;
        private readonly IContactRepository _contactRepository = contactRepository;
        private readonly IAboutRepository _aboutRepository = aboutRepository;
        private readonly ICafeContactInfoRepository _cafeContactInfoRepository = cafeContactInfoRepository;
        private readonly RepositoryContext _context = context;

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public IContactRepository Contact => _contactRepository;

        public IAboutRepository About => _aboutRepository;

        public ICafeContactInfoRepository CafeContactInfo => _cafeContactInfoRepository;

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
