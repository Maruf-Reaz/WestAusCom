using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;
using WestAusAPI.Repository;

namespace WestAusAPI.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerRepository.DeleteCustomer(customer);
        }

        public Customer EditCustomer(Customer customer)
        {
            return _customerRepository.EditCustomer(customer);
        }



    }
}
