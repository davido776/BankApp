using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeoplesBank.Data
{
    public class AccountDb : IAccountDataHandler
    {
        private static PeoplesBankDbContext _context;

        public AccountDb(PeoplesBankDbContext context)
        {
            _context = context;
        }
        public void AddAccount(Account acct)
        {
            
            _context.Accounts.Add(acct);
            _context.SaveChanges();
        }

        public Account GetAccountByNumber(string acctno)
        {
            return _context.Accounts.FirstOrDefault(a => a.AccountNumber == acctno);
        }
        public List<Account> GetAccountByOwnerId(string ownerid)
        {
            return _context.Accounts.Where(a => a.OwnerId == ownerid).ToList();
        }

        public List<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
