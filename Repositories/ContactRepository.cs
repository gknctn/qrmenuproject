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
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(RepositoryContext context) : base(context)
        {
        }

        public void AddContact(Contact contact, bool trackChanges) => AddItem(contact, trackChanges);

        public void DeleteContact(Contact contact, bool trackChanges)=>DeleteItem(contact, trackChanges);

        public IQueryable<Contact> GetAllContact(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<Contact> GetLast3Contact(bool trackChanges) => GetAll(trackChanges).OrderByDescending(c => c.ContactId).Take(3);

        public Contact? GetOneContact(int id, bool trackChanges) => GetByCondition(x => x.ContactId == id, trackChanges);
    }
}
