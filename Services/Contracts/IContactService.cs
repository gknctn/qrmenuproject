using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IContactService
    {
        IQueryable<Contact> GetAllContact(bool trackChanges);
        IQueryable<Contact> GetLast3Contact(bool trackChanges);
        void AddContact(Contact contact, bool trackChanges);
        Contact? GetOneContact(int id, bool trackChanges);
        void DeleteContact(Contact contact, bool trackChanges);

    }
}
