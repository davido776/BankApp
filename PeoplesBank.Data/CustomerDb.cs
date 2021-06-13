using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;

namespace PeoplesBank.Data
{
    public class CustomerDb : ICustomerDataHandler
    {
        private static PeoplesBankDbContext _context;
        public CustomerDb(PeoplesBankDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer cust)
        {
            if(cust != null)
                _context.Customers.Add(cust);
            _context.SaveChanges();
        }

       

        public Customer GetCustomerById(string id)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == id);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(c => c.Email == email);
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
