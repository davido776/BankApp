using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Core.Interfaces
{
    public interface IAuthRepository
    {
        string[] Register(string id,string fname, string lname, string email, string password);
        bool Login(string email, string password);
        void Logout();
    }
}
