using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppAssign2
{
    public class Bank_11
    {

        //Assignment 11: Initializing a Static Field
        //Problem Statement: Create a class Bank that has a static field for the interest rate and a non-
        //static field for the account holder’s balance.Write a static constructor to initialize the interest
        //rate to a default value and a regular constructor for setting up the account balance.

        public static double InterestRate;
        public double Balance;

        static Bank_11()
        {
            InterestRate = 0.4;
        }

        public Bank_11(double balance) {
            Balance = balance;
        }

         public static void DisplayInterest()
        {
            Console.WriteLine("The interest rate is " + InterestRate);
        }

        public void DisplayBalance()
        {
            Console.WriteLine("The balance is " + Balance);
        }
    }
}
