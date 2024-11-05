using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_4
{
    public  class Delegates
    {
        public void Print(string message) 
        {
            Console.WriteLine(value: "The message is : " + message);
        }

        public void Print2(string message)
        {
            Console.WriteLine("The message in Print2: " + message);
        }
    }
}
