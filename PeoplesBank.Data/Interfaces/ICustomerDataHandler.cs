using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Data.Interfaces
{
    public interface ICustomerDataHandler
    {
        void AddCustomer(Customer cust);
        Customer GetCustomerById(string Id);

        Customer GetCustomerByEmail(string email);

        List<Customer> GetCustomers();
    }
}
