using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();

        Contact GetContact(int id);
        List<Contact> GetCustomerContact(int id);

        Contact AddContact(Contact contact);

        void DeleteContact(Contact contact);

        Contact EditContact(Contact contact);

    }
}
