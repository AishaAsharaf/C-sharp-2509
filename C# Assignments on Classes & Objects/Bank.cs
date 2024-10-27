using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Bank
    {
        //Assignment 4: Banking System
        //Problem Statement: Create a simple banking system that allows account creation and basic
        //transactions.Each account has an account number, account holder name, and balance. Implement
        //deposit and withdrawal methods.Use getters and setters to manage access to the balance,
        //ensuring it cannot be set to a negative value.

        public string AccountNumber;
        public string Name;
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be zero");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public Bank(string accountNumber, string name)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
            this.Balance = 0;
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("The new Balane is " + Balance);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("The new Balane is " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }


    }
}
