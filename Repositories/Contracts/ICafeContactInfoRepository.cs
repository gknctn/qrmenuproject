using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ICafeContactInfoRepository
    {
        CafeContactInfo? GetOneCafeContactInfo(int id, bool trackChanges);
        void EditCafeContactInfo(CafeContactInfo cafeContactInfo, bool trackChanges);
    }
}
