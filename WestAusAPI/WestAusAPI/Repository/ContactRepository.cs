using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WestAusAPI.Data;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public class ContactRepository : IContactRepository
    {

       
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Contact> GetContacts()
        {
            return _context.Contacts.Include(m=>m.Customer).ToList();
        }
        public Contact GetContact(int id)
        {
            return _context.Contacts.Include(m => m.Customer).Where(m=>m.Id==id).SingleOrDefault();
        }
        public List<Contact> GetCustomerContact(int id)
        {
            return _context.Contacts.Include(m=>m.Customer).Where(m=>m.CustomerId==id).ToList();
        }

        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return contact;
        }

        public void DeleteContact(Contact contact)
        {

            _context.Remove(contact);
            _context.SaveChanges();
        }

        public Contact EditContact(Contact contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
            return contact;
        }


    }
}
