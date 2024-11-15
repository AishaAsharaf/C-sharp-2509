using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class Order
    {
        //Assignment 3. Identify the need for enumerations

        //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
        //Define an Order class with an OrderStatus property to manage the status of each order.

        public OrderStatus Type;

        public OrderStatus Status { get; set; }
        public void OrderStatusView()
        {
            switch (Type)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("The order - pending.");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("The order - shipped.");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("The order - delivered.");
                    break;
                default:
                    Console.WriteLine("Unknown status.");
                    break;
            }
         }
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered
        }
    }
}
