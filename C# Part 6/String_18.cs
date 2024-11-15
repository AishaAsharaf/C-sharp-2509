using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_18
    {
        //Assignment 18. Write a C# program to check if a string contains only digits.
        public void OnlyDigits(string main)
        {
            if (string.IsNullOrEmpty(main))
            {
                Console.WriteLine("Null");
            }

            try
            {
                int value = Convert.ToInt32(main);
                Console.WriteLine("The string contain only digits " +  value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
