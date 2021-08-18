using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestAusAPI.Model;

namespace WestAusAPI.Service
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetCustomer(int id);

        Customer AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        Customer EditCustomer(Customer customer);

    }
}
