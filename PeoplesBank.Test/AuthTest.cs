using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PeoplesBank.Core.Interfaces;
using PeoplesBank.Core.Services;
using PeoplesBank.Data;
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Helpers;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Test
{
    [TestClass]
    public class AuthTest
    {
        [TestMethod]
        public void Register()
        {
            var id = Guid.NewGuid().ToString();
            var custdatamock = new Mock<ICustomerDataHandler>();
            var custrepomock = new Mock<ICustomerRepository>();
            var mockSet = new Mock<DbSet<Customer>>();
            var mockContext = new Mock<PeoplesBankDbContext>();

            var authrepo = new AuthRepository(custdatamock.Object, custrepomock.Object);

            var registerrespponse = authrepo.Register(id,"jesse", "lingard", "jesse@g.com", "678");
            Assert.AreEqual("success", registerrespponse[0]);

        }
       
    }
}
