using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Data.Interfaces
{
    public interface ITransactionDataHandler
    {
        void AddTransaction(Transact t);
        List<Transact> GetTransactionByAccountNumber(string acctno);

        void UpdateAccount(string acctno, int bal);
    }
}
