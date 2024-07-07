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
    public class AboutManager : IAboutService
    {
        private readonly IRepositoryManager _manager;

        public AboutManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void EditAbout(About about, bool trackChanges)
        {
            _manager.About.EditAbout(about, trackChanges);
            _manager.save();
        }

        public About? GetOneAbout(int id, bool trackChanges) => _manager.About.GetOneAbout(id, trackChanges);
    }
}
