using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_7
    {
        //Assignment 7. Write a C# program to find substring occurrence within a main string.

        public void FindSubString(string mainString, string subString)
        {
            if (mainString == null)
            {

                Console.WriteLine("The main string is empty");
                
            }
         
            int index = 0;
            int count = 0;
               
                
            while (index <= mainString.Length - subString.Length) {
                if (mainString.Substring(index, subString.Length) == subString) 
                { 
                     count++;
                     index += subString.Length;
                     
                }
                else
                {
                index++;
                }
            }
            Console.WriteLine("The count is : " + count);
   
        }


    }
}
