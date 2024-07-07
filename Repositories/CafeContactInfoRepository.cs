using Entities.Models;
using qrmenuproject.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CafeContactInfoRepository : RepositoryBase<CafeContactInfo>, ICafeContactInfoRepository
    {
        public CafeContactInfoRepository(RepositoryContext context) : base(context)
        {
        }

        public void EditCafeContactInfo(CafeContactInfo cafeContactInfo, bool trackChanges) => EditItem(cafeContactInfo, trackChanges);

        public CafeContactInfo? GetOneCafeContactInfo(int id, bool trackChanges) => GetByCondition(p => p.CafeContactInfoId == id, trackChanges);
    }
}
