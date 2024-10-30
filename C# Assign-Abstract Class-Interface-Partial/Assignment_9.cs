using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_Interface_Partial
{
    public class Library
    {
        //Assignment 9. Indexer
        //Create a Library class that contains an array of Book objects.Implement an indexer that allows
        //accessing the books by index.Write a method to display all the books in the library.

        private string[] books = new string[10];

        public string this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }

        public void DisplayAll()
        {
            foreach (var book in books)
            {
                Console.Write(" " + book);
            }
        }
    }
}
