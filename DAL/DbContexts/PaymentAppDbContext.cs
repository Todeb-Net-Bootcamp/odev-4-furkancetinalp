using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbContexts
{
    public class PaymentAppDbContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CustomerList> CustomerLists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAddress> BankAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql kullanılacağı için UseSqlServer yazıldı ve içine connectionstring eklendi.
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=DESKTOP-J1KC895\\SQLEXPRESS;Database=PaymentApp;Trusted_Connection=True;"));

        }

    }
}
