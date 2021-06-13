using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PeoplesBank.Data;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeoplesBank.Test
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void AddTransaction_Runs()
        {
            var transact = new Transact
            {
                AccountNumber = "09876666",
                Amount = 2000,
                Note = "a transaction",
                AccountType = "current",
                TransactionDate = DateTime.Now,
                Id = Guid.NewGuid().ToString()
             };

            var mockSet = new Mock<DbSet<Transact>>();

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Transactions).Returns(mockSet.Object);

            var transactdb = new TransactionDb(mockContext.Object);
            transactdb.AddTransaction(transact);

            mockSet.Verify(m => m.Add(It.IsAny<Transact>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void GetTransactionByAccountNumber_Returns_AccountList()
        {
            
            var transactions = new List<Transact>()
            {
                 new Transact
                {
                     AccountNumber = "09876666",
                    Amount = 4000,
                    Note = "a transaction",
                    AccountType = "current",
                    TransactionDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString()
                },
                new Transact
                {
                     AccountNumber = "09876666",
                    Amount = 2000,
                    Note = "a transaction",
                    AccountType = "savings",
                    TransactionDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString()
                },
                new Transact
                {
                    AccountNumber = "09873333333",
                    Amount = 2000,
                    Note = "a transaction",
                    AccountType = "current",
                    TransactionDate = DateTime.Now,
                    Id = Guid.NewGuid().ToString()
                }
            }.AsQueryable();
            var acctno = "09876666";
            var mockSet = new Mock<DbSet<Transact>>();
            mockSet.As<IQueryable<Transact>>().Setup(m => m.Provider).Returns(transactions.Provider);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.Expression).Returns(transactions.Expression);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.ElementType).Returns(transactions.ElementType);
            mockSet.As<IQueryable<Transact>>().Setup(m => m.GetEnumerator()).Returns(transactions.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Transactions).Returns(mockSet.Object);

            var transactdb = new TransactionDb(mockContext.Object);
            var retrievedaccount = transactdb.GetTransactionByAccountNumber(acctno);

            Assert.AreEqual(2, retrievedaccount.Count);

        }

    }
}
