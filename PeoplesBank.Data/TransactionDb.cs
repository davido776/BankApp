using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeoplesBank.Data
{
    public class TransactionDb : ITransactionDataHandler
    {
        private static PeoplesBankDbContext _context;
        public TransactionDb(PeoplesBankDbContext context)
        {
            _context = context;
        }
        public void AddTransaction(Transact t)
        {
            _context.Transactions.Add(t);
            _context.SaveChanges();
        }

        public List<Transact> GetTransactionByAccountNumber(string acctno)
        {
            return _context.Transactions.Where(t => t.AccountNumber == acctno).ToList();
        }
        public void UpdateAccount(string acctno,int bal)
        {
           
            var account = _context.Accounts.Single(a => a.AccountNumber == acctno);
            account.Balance = bal;
            _context.SaveChanges();

        }
    }
}
