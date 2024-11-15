using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_8
    {
        //Assignment 8. Using Delegates to Hold Methods with the Same Signature
        //Question:
        //Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
        //string. Write three different methods that modify the string in different ways (e.g., convert to
        //uppercase, reverse, add a prefix). Use the delegate to call each method. 

        public void UpperCase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public void Reverse(string message)
        {
            Console.WriteLine("Reverse : ");
            int length = message.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
        }


        public void AddPrefix(string prefix) {
           Console.WriteLine("\n Write the prefix to add");
           string prefixtoAdd = Console.ReadLine();

           Console.WriteLine($"\n Add Prefix : {prefixtoAdd}{prefix}");

        }
    }
}
