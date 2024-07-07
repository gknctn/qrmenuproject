using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
        IQueryable<Contact> GetAllContact(bool trackChanges);
        void AddContact(Contact contact, bool trackChanges);
        Contact? GetOneContact(int id, bool trackChanges);
        void DeleteContact(Contact contact, bool trackChanges);
    }
}
