
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Transactions;

namespace PeoplesBank.Data
{
    public class TransactionData : ITransactionDataHandler
    {
        private static string file = @"C:\Users\hp\source\transactions.txt";
        public void AddTransaction(Transact t)
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                // iterates over the users

                // creates an array of the user's values
                string[] values = { t.Id, t.AccountNumber, t.Amount.ToString(), t.Note, t.AccountType, t.TransactionDate.ToString() };
                // creates a new line
                string line = string.Join(";", values);
                // writes the line
                sw.WriteLine(line);


                // flushes the buffer
                sw.Flush();
            }
        }
        public List<Transact> GetTransactionByAccountNumber(string accno)
        {
            var transactions = new List<Transact>(); 
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');
                    if(values[1] == accno)
                    {
                        Transact t = new Transact(values[0], values[1], Decimal.Parse(values[2]), values[3], values[4], DateTime.Parse(values[5]));
                        transactions.Add(t);
                    }
                }

            }
            return transactions;
        }

        public void UpdateAccount(string acctno, int bal)
        {
            throw new NotImplementedException();
        }
    }
}
