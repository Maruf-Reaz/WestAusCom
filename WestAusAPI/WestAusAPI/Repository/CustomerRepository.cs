using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WestAusAPI.Data;
using WestAusAPI.Model;

namespace WestAusAPI.Repository
{
    public class CustomerRepository:ICustomerRepository
    {

       
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customers.Include(m=>m.Locations).Include(m=>m.Contacts).Include(m=>m.ShipToLocations).ToList();
        }
        public Customer GetCustomer(int id)
        {
            return _context.Customers.Include(m => m.Locations).Include(m => m.Contacts).Include(m => m.ShipToLocations).Where(m=>m.Id==id).SingleOrDefault();
        }

        public Customer AddCustomer(Customer customer)
        {
            
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {

            _context.Remove(customer);
            _context.SaveChanges();
        }

        public Customer EditCustomer(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }


    }
}
