using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IContactRepository Contact { get; }
        IAboutRepository About { get; }
        ICafeContactInfoRepository CafeContactInfo { get; }
        void save();
    }
}
