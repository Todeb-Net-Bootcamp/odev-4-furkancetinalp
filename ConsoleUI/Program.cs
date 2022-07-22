using DAL.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var conn = new PaymentAppDbContext())
            {
                var bank1 = new Bank
                {
                    Name = "Akbank"
                };
                conn.Banks.Add(bank1);
                conn.SaveChanges();

                var bankaddress1 = new BankAddress
                {
                    Country = "Turkey",
                    City = "Istanbul",
                    PostalCode = 121,
                    BankId = bank1.Id,

                };
                conn.BankAddresses.Add(bankaddress1);
                conn.SaveChanges();

                var customerlist = new CustomerList
                {
                    BankId = bank1.Id,
                    Customers= new List<Customer>()
                    {
                        new Customer()
                        {
                            Name="Name1",
                            Surname="Surname1",
                            Address = new Address()
                            {
                                City="Ankara",
                                PostalCode=6,
                                Country="Turkey",
                                District="Cankaya",
                                Street="Street Name",
                                HouseCode=175
                            }
                        }
                    }
                };
                conn.CustomerLists.Add(customerlist);
                conn.SaveChanges();
                var customerId = conn.Customers.SingleOrDefault(x=>x.Name=="Name1").Id;
                var account1 = new Account { CustomerId=customerId };

                var creditcard = new CardType { Name = "Credit Card" };
                var bankcard = new CardType { Name = "Bank Card" };

                conn.Accounts.Add(account1);
                conn.SaveChanges();

                conn.CardTypes.Add(creditcard);
                conn.CardTypes.Add(bankcard);
                conn.SaveChanges();

                var card1 = new Card
                {
                    AccountId = account1.Id,
                    CardTypeId = creditcard.Id,
                    balance = 100,
                    IBAN = "TR1234567654321234"

                };
                var card2 = new Card
                {
                    AccountId = account1.Id,
                    CardTypeId = bankcard.Id,
                    balance = 200,
                    IBAN = "TR234345643245324"
                };

                conn.Cards.Add(card1);
                conn.Cards.Add(card2);
                conn.SaveChanges();
            }
        }
    }
}
