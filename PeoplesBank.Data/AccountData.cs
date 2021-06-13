
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeoplesBank.Data
{
    public class AccountData:IAccountDataHandler
    {
        private static string file = @"C:\Users\hp\source\myaccounts.txt";

        public void AddAccount(Account a)
        {

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                // creates an array of the model values
                string[] values = { a.AccountNumber, a.OwnerId, a.Balance.ToString(), a.Type, a.DateCreated.ToString(), a.MinBalance.ToString() };
                // creates a new line
                string line = string.Join(";", values);
                // writes the line
                sw.WriteLine(line);
                // flushes the buffer
                sw.Flush();
            }
        }

        public Account GetAccountByNumber(string acctno)
        {
            Account a = null;
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');
                    if (values[0] == acctno)
                    {
                        a = new Account(values[0], values[1], Decimal.Parse(values[2]), values[3], DateTime.Parse(values[4]));
                        a.MinBalance = Decimal.Parse(values[5]);
                    }
                }
            }
            return a;
        }

        public List<Account> GetAccountByOwnerId(string ownerid)
        {
            var accounts = new List<Account>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');
                    if (values[1] == ownerid)
                    {
                        var account = new Account(values[0], values[1], Decimal.Parse(values[2]), values[3], DateTime.Parse(values[4]));
                        account.MinBalance = Decimal.Parse(values[5]);
                        accounts.Add(account);
                    }
                }
            }
            return accounts;
        }

        public List<Account> GetAccounts()
        {
            var AllAccounts = new List<Account>();
            // Opens the file for reading
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');

                    var account = new Account(values[0], values[1], Decimal.Parse(values[2]), values[3], DateTime.Parse(values[4]));
                    account.MinBalance = Decimal.Parse(values[5]);
                    AllAccounts.Add(account);

                    
                }
            }
            return AllAccounts;
        }

    }
}
