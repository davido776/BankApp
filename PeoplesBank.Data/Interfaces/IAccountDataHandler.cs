using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Data.Interfaces
{
    public interface IAccountDataHandler
    {
        void AddAccount(Account acct);
        Account GetAccountByNumber(string acctno);
        List<Account> GetAccountByOwnerId(string ownerid);
        List<Account> GetAccounts();
    }
}
