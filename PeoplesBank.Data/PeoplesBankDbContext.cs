using Microsoft.EntityFrameworkCore;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeoplesBank.Data
{
    public class PeoplesBankDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Account>  Accounts { get; set; }

        public virtual DbSet<Transact> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SQLitePCL.Batteries.Init();
            
            optionsBuilder.UseSqlite(@"Data Source= C:\Users\hp\source\repos\weeklytask\PeoplesBank\PeoplesBank.Data\PeoplesBank.db");
       

        }
    }
}
