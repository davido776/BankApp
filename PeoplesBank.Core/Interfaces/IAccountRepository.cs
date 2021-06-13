using PeoplesBank;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Core.Interfaces
    
{
    public interface IAccountRepository
    {
        void CreateAccount(string id,string type, decimal initialdeposit);
        void Deposit(string accno, decimal amt, string type);
        string[] Withdraw(string accno, decimal amt, string type);
        string[] Transfer(string senderNumber, string receiverNumber, decimal amt, string type);
        decimal GetBalance(string accno);
    }
}
