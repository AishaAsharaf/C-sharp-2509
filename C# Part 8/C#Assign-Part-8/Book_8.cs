using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_Assign_Part_8
{
    public class Book_8
    {
        //8. Text File Serialization and Deserialization with XML
        //Question:
        //Define a Book class with properties Title, Author, and ISBN.Write a program that serializes an
        //instance of Book to an XML file named "book.xml" and then deserializes it back, displaying the
        //details on the console.
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
