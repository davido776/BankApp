using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using PeoplesBank.Data;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeoplesBank.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void AddCustomer_Runs_Correct()
        {
            var date = DateTime.Now;
            var id = Guid.NewGuid().ToString();
            var password = "6789";
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var customer = new Customer
            {
                Id = id,
                DateCreated = date,
                LastName = "Rebekah",
                FirstName = "Mikelson",
                Email = "rebekah@gmail.com",
                PasswordHash = passwordhash,
                PasswordSalt = passwordsalt,
             };

            var mockSet = new Mock<DbSet<Customer>>();
            var mockContext = new Mock<PeoplesBankDbContext>();
            
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var customerdb = new CustomerDb(mockContext.Object);
            customerdb.AddCustomer(customer);

            mockSet.Verify(m => m.Add(It.IsAny<Customer>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());


        }

        [TestMethod]
        public void GetCustomerById_Returns_Customer()
        {
            var date = DateTime.Now;
            var id1 = Guid.NewGuid().ToString();
            var id2= Guid.NewGuid().ToString();
            var id3 = Guid.NewGuid().ToString();
            var password = "6789";
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var customer = new Customer
            {
                Id = id1,
                DateCreated = date,
                LastName = "Rebekah",
                FirstName = "Mikelson",
                Email = "rebekah@gmail.com",
                PasswordHash = passwordhash,
                PasswordSalt = passwordsalt,
            };
            var customers = new List<Customer>()
            {
               
                customer,
                  new Customer{
                    Id = id2,
                    DateCreated = date,
                    LastName = "Elijah",
                    FirstName = "Mikelson",
                    Email = "elijah@gmail.com",
                    PasswordHash = passwordhash,
                    PasswordSalt = passwordsalt,
                },
                   new Customer
                   {
                        Id = id3,
                        DateCreated = date,
                        LastName = "Kol",
                        FirstName = "Mikelson",
                        Email = "kol@gmail.com",
                        PasswordHash = passwordhash,
                        PasswordSalt = passwordsalt,
                    }
            }.AsQueryable();
            var expectedcustomer = customer;

            var customerid = id1;

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(customers.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(customers.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(customers.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(customers.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var customerdb = new CustomerDb(mockContext.Object);
            var retrievedcustomer = customerdb.GetCustomerById(customerid);

            var expectedStr = JsonConvert.SerializeObject(expectedcustomer);
            var retrievedStr = JsonConvert.SerializeObject(retrievedcustomer);


            Assert.AreEqual(expectedStr, retrievedStr);
        }
        [TestMethod]
        public void GetCustomerById_Returns_Null()
        {
            var date = DateTime.Now;
            var id1 = Guid.NewGuid().ToString();
            var id2 = Guid.NewGuid().ToString();
            var id3 = Guid.NewGuid().ToString();
            var testid = Guid.NewGuid().ToString();
            var password = "6789";
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var customer = new Customer
            {
                Id = id1,
                DateCreated = date,
                LastName = "Rebekah",
                FirstName = "Mikelson",
                Email = "rebekah@gmail.com",
                PasswordHash = passwordhash,
                PasswordSalt = passwordsalt,
            };
            var customers = new List<Customer>()
            {

                customer,
                  new Customer{
                    Id = id2,
                    DateCreated = date,
                    LastName = "Elijah",
                    FirstName = "Mikelson",
                    Email = "elijah@gmail.com",
                    PasswordHash = passwordhash,
                    PasswordSalt = passwordsalt,
                },
                   new Customer
                   {
                        Id = id3,
                        DateCreated = date,
                        LastName = "Kol",
                        FirstName = "Mikelson",
                        Email = "kol@gmail.com",
                        PasswordHash = passwordhash,
                        PasswordSalt = passwordsalt,
                    }
            }.AsQueryable();
            var expectedcustomer = customer;

            var customerid = id1;

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(customers.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(customers.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(customers.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(customers.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var customerdb = new CustomerDb(mockContext.Object);
            var retrievedcustomer = customerdb.GetCustomerById(testid);

            Assert.IsNull(retrievedcustomer);
        }



        [TestMethod]
        public void GetCustomerByEmail_Returns_Customer()
        {
            var date = DateTime.Now;
            var id1 = Guid.NewGuid().ToString();
            var id2 = Guid.NewGuid().ToString();
            var id3 = Guid.NewGuid().ToString();
            var password = "6789";
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var customer = new Customer
            {
                Id = id1,
                DateCreated = date,
                LastName = "Rebekah",
                FirstName = "Mikelson",
                Email = "rebekah@gmail.com",
                PasswordHash = passwordhash,
                PasswordSalt = passwordsalt,
            };
            var customers = new List<Customer>()
            {
                
                customer,
                  new Customer{
                    Id = id2,
                    DateCreated = date,
                    LastName = "Elijah",
                    FirstName = "Mikelson",
                    Email = "elijah@gmail.com",
                    PasswordHash = passwordhash,
                    PasswordSalt = passwordsalt,
                },
                   new Customer
                   {
                        Id = id3,
                        DateCreated = date,
                        LastName = "Kol",
                        FirstName = "Mikelson",
                        Email = "kol@gmail.com",
                        PasswordHash = passwordhash,
                        PasswordSalt = passwordsalt,
                    }
            }.AsQueryable();
            var expectedcustomer = customer;

            var customeremail = "rebekah@gmail.com";

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(customers.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(customers.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(customers.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(customers.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var customerdb = new CustomerDb(mockContext.Object);
            var retrievedcustomer = customerdb.GetCustomerByEmail(customeremail);

            var expectedStr = JsonConvert.SerializeObject(expectedcustomer);
            var retrievedStr = JsonConvert.SerializeObject(retrievedcustomer);


            Assert.AreEqual(expectedStr, retrievedStr);
        }
        [TestMethod]
        public void GetCustomerByEmail_Returns_Null()
        {
            var date = DateTime.Now;
            var id1 = Guid.NewGuid().ToString();
            var id2 = Guid.NewGuid().ToString();
            var id3 = Guid.NewGuid().ToString();
            var password = "6789";
            var hashes = Helper.GenerateHash(password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];
            var customer = new Customer
            {
                Id = id1,
                DateCreated = date,
                LastName = "Rebekah",
                FirstName = "Mikelson",
                Email = "rebekah@gmail.com",
                PasswordHash = passwordhash,
                PasswordSalt = passwordsalt,
            };
            var customers = new List<Customer>()
            {

                customer,
                  new Customer{
                    Id = id2,
                    DateCreated = date,
                    LastName = "Elijah",
                    FirstName = "Mikelson",
                    Email = "elijah@gmail.com",
                    PasswordHash = passwordhash,
                    PasswordSalt = passwordsalt,
                },
                   new Customer
                   {
                        Id = id3,
                        DateCreated = date,
                        LastName = "Kol",
                        FirstName = "Mikelson",
                        Email = "kol@gmail.com",
                        PasswordHash = passwordhash,
                        PasswordSalt = passwordsalt,
                    }
            }.AsQueryable();
            var expectedcustomer = customer;

            var testemail = "subzero@gmail.com";

            var mockSet = new Mock<DbSet<Customer>>();
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Provider).Returns(customers.Provider);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.Expression).Returns(customers.Expression);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.ElementType).Returns(customers.ElementType);
            mockSet.As<IQueryable<Customer>>().Setup(m => m.GetEnumerator()).Returns(customers.GetEnumerator());

            var mockContext = new Mock<PeoplesBankDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);
            var customerdb = new CustomerDb(mockContext.Object);
            var retrievedcustomer = customerdb.GetCustomerByEmail(testemail);

            Assert.IsNull(retrievedcustomer);
        }
    }
}
