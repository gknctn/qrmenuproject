using Entities.Models;
using qrmenuproject.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AboutRepository : RepositoryBase<About>, IAboutRepository
    {
        public AboutRepository(RepositoryContext context) : base(context)
        {
        }

        public void EditAbout(About about, bool trackChanges)=>EditItem(about, trackChanges);

        public About? GetOneAbout(int id, bool trackChanges) => GetByCondition(x => x.AboutId == id, false);
    }
}
