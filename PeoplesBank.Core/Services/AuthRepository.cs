
using System;
using System.Collections.Generic;
using System.Text;
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;



namespace PeoplesBank.Core.Services
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ICustomerDataHandler _custdata;
        public static Customer CurrentUser;
        private readonly ICustomerRepository _custrepo;
        public AuthRepository(ICustomerDataHandler custdb, ICustomerRepository custrepo)
        {
           
            _custrepo = custrepo;
            _custdata = custdb;
        }
        public string[] Register(string id,string fname, string lname, string email, string password)
        {
            string[] res = new string[2];
             if (EmailExist(email))
             {
                res[0] = "failed";
                res[1] = "Email Already Exists";
             }
            else
            {
                _custrepo.CreateCustomer(id,fname, lname, email,  password);
                res[0] = "success";
            }
            return res;   
           
        }

        public bool Login(string email, string password)
        {
            if (!IsValidCred(email, password))
            {
                return false;
            }
            return true;
        
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

       
        private bool IsValidCred(string email, string password)
        {
            bool passwordMatch = false;
            var cust = _custdata.GetCustomerByEmail(email);
            if (cust == null)
                passwordMatch = false;
            if (Helper.CompareHash(cust.PasswordSalt, cust.PasswordHash, password))
                passwordMatch = true;

            return passwordMatch;
        }
        internal bool EmailExist(string email)
        {
            var cust = _custdata.GetCustomerByEmail(email);
            if(cust == null)
            {
                return false;
            }
            return true;
        }

        
    }
}
