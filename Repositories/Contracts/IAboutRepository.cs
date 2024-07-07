using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAboutRepository : IRepositoryBase<About>
    {
        About? GetOneAbout(int id, bool trackChanges);
        void EditAbout(About about, bool trackChanges);
    }
}
