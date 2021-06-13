using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using System;
using System.Data.SqlClient;

namespace PeoplesBank.Config
{
    public class GlobalConfig
    {
        public static IAccountRepository IAccountinstance { get; private set; }
        public static ICustomerRepository ICustomerinstance { get; private set; }
        public static IAuthRepository IAuthinstance { get; private set; }
        public static ICustomerDataHandler ICustomerdhinstance { get; private set; }
        public static IAccountDataHandler IAccountdhinstance { get; private set; }
        public static ITransactionDataHandler ITransactiondhinstance { get; private set; }

        public  static PeoplesBankDbContext contextobj = new PeoplesBankDbContext();

        public static void AddIinstance()
        {
            AccountRepository op = new AccountRepository(new AccountDb(contextobj), new TransactionDb(contextobj));
            CustomerDb cd = new CustomerDb(contextobj);
            AccountDb ad = new AccountDb(contextobj);
            TransactionDb td = new TransactionDb(contextobj);
            CustomerRepository oc = new CustomerRepository(new CustomerDb(contextobj));
            AuthRepository ar = new AuthRepository(new CustomerDb(contextobj), new CustomerRepository(new CustomerDb(contextobj)));
            IAccountinstance = op;
            ICustomerinstance = oc;
            IAuthinstance = ar;
            ICustomerdhinstance = cd;
            IAccountdhinstance = ad;
            ITransactiondhinstance = td; 
        }

        public static void RemoveIinstance()
        {
            IAccountinstance = null;
            ICustomerinstance = null;
            IAuthinstance = null;
        }

        
    }
    
}
