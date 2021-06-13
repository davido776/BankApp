using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeoplesBank.Test
{
    [TestClass]
    public class AccountTest
    {
       
        
        [TestMethod]
        public void GetBalance_ReturnsBalance()
        {
            string accno = "09877777";
            var transactions = new List<Transact>()
            {
                new Transact
                {
                    AccountNumber = accno,
                    Amount = 3000,
                    Note = "deposit",
                    AccountType = "saving",
                    TransactionDate = DateTime.Now,
                    Id = "5678",
                },
                 new Transact
                {
                    AccountNumber = accno,
                    Amount = 4000,
                    Note = "deposit",
                    AccountType = "saving",
                    TransactionDate = DateTime.Now,
                    Id = "5678",
                },
                  new Transact
                {
                    AccountNumber = "4444444",
                    Amount = 4000,
                    Note = "deposit",
                    AccountType = "saving",
                    TransactionDate = DateTime.Now,
                    Id = "5678",
                }

            }.AsQueryable();
            
            List<Transact> transss = new List<Transact>() 
            {
                new Transact
                {
                    AccountNumber = accno,
                    Amount = 3000,
                    Note = "deposit",
                    AccountType = "saving",
                    TransactionDate = DateTime.Now,
                    Id = "5678",
                },
                 new Transact
                {
                    AccountNumber = accno,
                    Amount = 4000,
                    Note = "deposit",
                    AccountType = "saving",
                    TransactionDate = DateTime.Now,
                    Id = "5678",
                },
            };
            var mockSet = new Mock<DbSet<Transact>>();
            mockSet.As<IQueryable<Transact>>().Setup(m => m.Provider).Returns(transactions.Provider);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.Expression).Returns(transactions.Expression);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.ElementType).Returns(transactions.ElementType);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.GetEnumerator()).Returns(transactions.GetEnumerator());

            var tranmock = new Mock<ITransactionDataHandler>();
            tranmock.Setup(t => t.GetTransactionByAccountNumber(accno)).Returns(transss);
            var acctmock = new Mock<IAccountDataHandler>();

            var acctrepomock = new AccountRepository(acctmock.Object,tranmock.Object );

            var bal = acctrepomock.GetBalance(accno);

            Assert.AreEqual(7000,bal);

            

        }

        [TestMethod]
        public void AddAccount_Runs()
        {

            var account = new Account 
            {
                AccountNumber = "09844444",
                Balance = 2000,
                OwnerId = "234",
                Type = "savings",
                MinBalance = 1000,
                DateCreated = DateTime.Now
             };

            var mockSet = new Mock<DbSet<Account>>();

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);

            var acctdb = new AccountDb(mockContext.Object);
            acctdb.AddAccount(account);

            mockSet.Verify(m => m.Add(It.IsAny<Account>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }

        [TestMethod]
        public void GetAccountByNumber_Returns_Account()
        {
            var date = DateTime.Now;
            var account = new Account
            {
                AccountNumber = "09844444",
                Balance = 2000,
                OwnerId = "234",
                Type = "savings",
                MinBalance = 1000,
                DateCreated = date
            };
            var accounts = new List<Account>()
            {
                new Account
                {
                    AccountNumber = "09856789",
                    Balance = 3000,
                    OwnerId = "2567",
                    Type = "savings",
                    MinBalance = 1000,
                    DateCreated = date
                },
                account,
                  new Account
                {
                     AccountNumber = "098999999",
                    Balance = 8000,
                    OwnerId = "200",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                },
                   new Account
                   {
                    AccountNumber = "098111111",
                    Balance = 4000,
                    OwnerId = "5000",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                    }
            }.AsQueryable();
            var expectedaccount = account;
           
            var acctno = "09844444";

            var mockSet = new Mock<DbSet<Account>>();
            mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(accounts.Provider);
            mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(accounts.Expression);
            mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(accounts.ElementType);
            mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(accounts.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);

            var acctdb = new AccountDb(mockContext.Object);
            var retrievedaccount = acctdb.GetAccountByNumber(acctno);

            var expectedStr = JsonConvert.SerializeObject(expectedaccount);
            var retrievedStr = JsonConvert.SerializeObject(retrievedaccount);
            

            Assert.AreEqual(expectedStr, retrievedStr);
        }

        [TestMethod]
        public void GetAccountByNumber_Returns_Null()
        {
            var date = DateTime.Now;
            var account = new Account
            {
                AccountNumber = "09844444",
                Balance = 2000,
                OwnerId = "234",
                Type = "savings",
                MinBalance = 1000,
                DateCreated = date
            };
            var accounts = new List<Account>()
            {
                new Account
                {
                    AccountNumber = "09856789",
                    Balance = 3000,
                    OwnerId = "2567",
                    Type = "savings",
                    MinBalance = 1000,
                    DateCreated = date
                },
                account,
                  new Account
                {
                     AccountNumber = "098999999",
                    Balance = 8000,
                    OwnerId = "200",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                },
                   new Account
                   {
                    AccountNumber = "098111111",
                    Balance = 4000,
                    OwnerId = "5000",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                    }
            }.AsQueryable();
            var expectedaccount = account;

            var testacctno = "09888888";

            var mockSet = new Mock<DbSet<Account>>();
            mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(accounts.Provider);
            mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(accounts.Expression);
            mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(accounts.ElementType);
            mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(accounts.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);

            var acctdb = new AccountDb(mockContext.Object);
            var retrievedaccount = acctdb.GetAccountByNumber(testacctno);

            Assert.IsNull(retrievedaccount);
        }

        [TestMethod]
        public void GetAccountByOwnerId_Returns_Account()
        {
            var date = DateTime.Now;
            var account = new Account
            {
                AccountNumber = "09844444",
                Balance = 2000,
                OwnerId = "234",
                Type = "savings",
                MinBalance = 1000,
                DateCreated = date
            };
            var accounts = new List<Account>()
            {
                new Account
                {
                    AccountNumber = "09856789",
                    Balance = 3000,
                    OwnerId = "2567",
                    Type = "savings",
                    MinBalance = 1000,
                    DateCreated = date
                },
                account,
                  new Account
                {
                     AccountNumber = "098999999",
                    Balance = 8000,
                    OwnerId = "200",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                },
                   new Account
                   {
                    AccountNumber = "098111111",
                    Balance = 4000,
                    OwnerId = "5000",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                    }
            }.AsQueryable();
            var expectedaccount = account;

            var ownerid = "111111111";

            var mockSet = new Mock<DbSet<Account>>();
            mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(accounts.Provider);
            mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(accounts.Expression);
            mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(accounts.ElementType);
            mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(accounts.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);

            var acctdb = new AccountDb(mockContext.Object);
            var retrievedaccount = acctdb.GetAccountByOwnerId(ownerid);

            Assert.IsNull(retrievedaccount);
        }

        [TestMethod]
        public void GetAccountByOwnerId_Returns_Null()
        {
            var date = DateTime.Now;
            var account = new Account
            {
                AccountNumber = "09844444",
                Balance = 2000,
                OwnerId = "234",
                Type = "savings",
                MinBalance = 1000,
                DateCreated = date
            };
            var accounts = new List<Account>()
            {
                new Account
                {
                    AccountNumber = "09856789",
                    Balance = 3000,
                    OwnerId = "2567",
                    Type = "savings",
                    MinBalance = 1000,
                    DateCreated = date
                },
                account,
                  new Account
                {
                     AccountNumber = "098999999",
                    Balance = 8000,
                    OwnerId = "200",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                },
                   new Account
                   {
                    AccountNumber = "098111111",
                    Balance = 4000,
                    OwnerId = "5000",
                    Type = "current",
                    MinBalance = 1000,
                    DateCreated = date
                    }
            }.AsQueryable();
            var expectedaccount = account;

            var testownerid = "234";

            var mockSet = new Mock<DbSet<Account>>();
            mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(accounts.Provider);
            mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(accounts.Expression);
            mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(accounts.ElementType);
            mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(accounts.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);

            var acctdb = new AccountDb(mockContext.Object);
            var retrievedaccount = acctdb.GetAccountByOwnerId(testownerid);

            var expectedStr = JsonConvert.SerializeObject(expectedaccount);
            var retrievedStr = JsonConvert.SerializeObject(retrievedaccount[0]);


            Assert.AreEqual(expectedStr, retrievedStr);
        }



    }
}
