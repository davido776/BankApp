using PeoplesBank.Core.Interfaces;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;


namespace PeoplesBank.Core.Services
{
    
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerDataHandler _custdata;
        
        
        public CustomerRepository(ICustomerDataHandler custdb)
        {
           
            _custdata = custdb;
           

        }
        public void CreateCustomer(string id,string fname, string lname, string email, string password)
        {
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var date = DateTime.Now;
            
            //var id = Guid.NewGuid().ToString();
            var newcust = new Customer(id, fname, lname, email, date, passwordhash, passwordsalt);

            _custdata.AddCustomer(newcust);
        }

        public void GetStatements()
        {
            throw new NotImplementedException();
        }
    }
}
