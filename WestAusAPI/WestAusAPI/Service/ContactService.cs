using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;
using WestAusAPI.Repository;

namespace WestAusAPI.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<Contact> GetContacts()
        {
            return _contactRepository.GetContacts();
        }
        public Contact GetContact(int id)
        {
            return _contactRepository.GetContact(id);
        }
        public List<Contact> GetCustomerContact(int id)
        {
            return _contactRepository.GetCustomerContact(id);
        }

        public Contact AddContact(Contact contact)
        {
            return _contactRepository.AddContact(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _contactRepository.DeleteContact(contact);
        }

        public Contact EditContact(Contact contact)
        {
            return _contactRepository.EditContact(contact);
        }



    }
}
