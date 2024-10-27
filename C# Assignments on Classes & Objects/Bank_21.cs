using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssign2
{
    public class Bank_21
    {
        //Assignment 21: Banking System
        //Problem Statement:
        //You need to create a Bank class that contains a list of Customer objects.Each Customer can have
        //multiple Account objects (nested class). Implement methods to add customers, add accounts, and
        //display customer account details.


        //Tasks:
        //1. Create a Bank class with :
        //o A list of Customer objects.
        //o Methods to add customers and accounts, and to display customer details.


        //2. Create a nested Customer class with properties for Name and a list of accounts.

        //3. Create a nested Account class with properties for AccountNumber and Balance.

        //4. Demonstrate the functionality in the Main() method.
        public static List<Customer> accountsAll = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            accountsAll.Add(customer);
            Console.WriteLine($"Name:{customer.CustomerName}");
            Console.WriteLine("Customer added");
        }

        public void AddAccount_Main(Customer customer, string accountNumber, double initialBalance)
        {
            customer.AddAccount(new Account(accountNumber, initialBalance));
            Console.WriteLine($"Account No : {accountNumber}, balance : {initialBalance} add to customer :{customer.CustomerName}.");
        }

        public void DisplayAll()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("The total list is");
            foreach (var customer in accountsAll)
            {
                Console.WriteLine($"Name:{customer.CustomerName}");
                foreach(var  account in customer.Accounts)
                {
                    Console.WriteLine($"Account : {account.AccountNumber},balance : {account.Balance}");
                }
            }

        }

        public class Customer
        {
            public string CustomerName;
            public List<Account> Accounts;

            public Customer(string name) {
                   this.CustomerName = name;
                   this.Accounts = new List<Account>();

            }

            public void AddAccount(Account account)
            {
                Accounts.Add(account);
            }


        }
        public class Account
        {
            public string AccountNumber;
            public double Balance;

            public Account(string accountNumber, double balance)
            {
                this.AccountNumber = accountNumber;
                this.Balance = balance;
            }
        }
    }
}
