using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Core.Interfaces
{
    public interface ICustomerRepository
    {
        void CreateCustomer(string id,string fname, string lname, string email, string password);
        void GetStatements();
    }
}
