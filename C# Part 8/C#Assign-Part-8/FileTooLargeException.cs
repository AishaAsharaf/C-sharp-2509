using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assign_Part_8
{
    
        //7. Custom Exception Handling in File Operations
        //Question:
        //Create a custom exception class named FileTooLargeException which is thrown when a file
        //exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file
        //size is too large.Otherwise, it should display "File size is acceptable."

        public class FileTooLargeException : Exception
        {
            public FileTooLargeException(){

                Console.WriteLine("");
            }
        }
  
}
