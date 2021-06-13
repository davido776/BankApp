
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PeoplesBank.Core.Services
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IAccountDataHandler _acctdata;
        private readonly ITransactionDataHandler _transactdata;
        public AccountRepository(IAccountDataHandler acctdb, ITransactionDataHandler transactdb)
        {
           
            _acctdata = acctdb;
            _transactdata = transactdb;
            
        }
        public void CreateAccount(string id,string type, decimal initialdeposit)
        {
            string acctno = Helper.GenerateNumber();
            //var id = Guid.NewGuid().ToString();
            var date = DateTime.Now;
            var newacct = new Account(acctno, id, initialdeposit, type, date);
            var newtransact = new Transact(newacct.OwnerId, newacct.AccountNumber, initialdeposit, "Deposit to Account", newacct.Type, newacct.DateCreated);
           
            _acctdata.AddAccount(newacct);
            _transactdata.AddTransaction(newtransact);
        }

        public void Deposit(string accno, decimal amt, string type)
        {
            var TransactionDate = DateTime.Now;
            var id = Guid.NewGuid().ToString();
            var newtransact = new Transact(id, accno, amt, "Deposit to Account", type, TransactionDate);
           
            _transactdata.AddTransaction(newtransact);
            var bal = GetBalance(accno);
            _transactdata.UpdateAccount(accno,Convert.ToInt32(bal));
        }

        public string[] Transfer(string senderNumber, string receiverNumber, decimal amt, string type)
        {
            var res = new string[2];
            var senderaccount = _acctdata.GetAccountByNumber(senderNumber);
            var bal = GetBalance(senderNumber);
            if ((bal - amt) < senderaccount.MinBalance)
            {
                res[0] = "failed";
                res[1] = "INSUFFICIENT FUNDS: MINIMUM BALANCE EXCCEDED!";
                return res;
            }
            else
            {
                Withdraw(senderNumber, amt,type);
                Deposit(receiverNumber, amt,type);
                
                res[0] = "success";
            }

            return res;
            
           
        }

        public string[] Withdraw(string accno, decimal amt, string type)
        {
            var account = _acctdata.GetAccountByNumber(accno);
            var bal = GetBalance(accno);
            var res = new string[2];
            // Ensure the minimum balance is not exceeded
            if ((bal - amt) < account.MinBalance)
            {
                res[0] = "failed";
                res[1] = "INSUFFICIENT FUNDS : MINIMUM BALANCE EXCEEDED!";
                return res;
            }
            else
            {
                var TransactionDate = DateTime.Now;
                var id = Guid.NewGuid().ToString();
                var withdraw = new Transact(id, accno, -amt, "Withdraw", type, TransactionDate);
                
                _transactdata.AddTransaction(withdraw);
                var currentbal = GetBalance(accno);
                _transactdata.UpdateAccount(accno, Convert.ToInt32(currentbal));
                res[0] = "success";
            }
            return res;
           
        }
        public decimal GetBalance(string accno)
        {
            decimal balance = 0;
            var transactions = _transactdata.GetTransactionByAccountNumber(accno);
            foreach(Transact t in transactions)
            {
                    balance += t.Amount;
                
            }
            return balance;
        }

    }
}
