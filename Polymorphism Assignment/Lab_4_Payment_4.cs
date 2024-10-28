using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Payment_4
    {
        //Assignment 4. Scenario of Overriding

        //Consider a scenario of payment processing where different payment methods(e.g.,

        //CreditCardPayment, PayPalPayment) override the ProcessPayment() method of a base class

        //Payment. Write a C# program to demonstrate this scenario.

        public virtual void ProcessPayment()
        {
            Console.WriteLine("Payment Request Initiation");
        }
    }

    public class Bank_4 : Payment_4
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Credit Card Details Authentcation");
        }
    }

    public class Server_4 : Payment_4
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Authentication Complete");
        }
    }

    public class Credit_4 : Payment_4
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("CreditCardPayment");
        }
    }

    public class PayPall_4 : Payment_4
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("PayPalPayment");
        }
    }

    public class Complete_4 : Payment_4
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment Completed");
        }
    }
}
