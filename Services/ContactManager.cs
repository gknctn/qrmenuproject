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
    public class ContactManager : IContactService
    {

        private readonly IRepositoryManager _manager;

        public ContactManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void AddContact(Contact contact, bool trackChanges)
        {
            _manager.Contact.AddContact(contact, trackChanges);
            _manager.save();
        }

        public void DeleteContact(Contact contact, bool trackChanges)
        {
            _manager.Contact.DeleteContact(contact, trackChanges);
            _manager.save();
        }

        public IQueryable<Contact> GetAllContact(bool trackChanges)
        {
            IQueryable<Contact> values = _manager.Contact.GetAllContact(trackChanges);
            return values;
        }

        public IQueryable<Contact> GetLast3Contact(bool trackChanges)
        {
            IQueryable<Contact> values = _manager.Contact.GetLast3Contact(trackChanges);
            return values;
        }

        public Contact? GetOneContact(int id, bool trackChanges)
        {
            Contact? value = _manager.Contact.GetOneContact(id, trackChanges);
            return value;
        }
    }
}
