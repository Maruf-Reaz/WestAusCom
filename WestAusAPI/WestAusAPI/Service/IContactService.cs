using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Service
{
    public interface IContactService
    {
        List<Contact> GetContacts();

        Contact GetContact(int id);
        List<Contact> GetCustomerContact(int id);

        Contact AddContact(Contact contact);

        void DeleteContact(Contact Contact);

        Contact EditContact(Contact Contact);

    }
}
