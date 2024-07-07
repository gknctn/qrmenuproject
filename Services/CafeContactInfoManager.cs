using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CafeContactInfoManager : ICafeContactInfoService
    {
        private readonly IRepositoryManager _manager;

        public CafeContactInfoManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void EditCafeContactInfo(CafeContactInfo cafeContactInfo, bool trackChanges)
        {
            _manager.CafeContactInfo.EditCafeContactInfo(cafeContactInfo,trackChanges);
            _manager.save();
        }

        public CafeContactInfo? GetOneCafeContactInfo(int id, bool trackChanges)
        {
            return _manager.CafeContactInfo.GetOneCafeContactInfo(id, trackChanges);
        }
    }
}
