using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static Nov_4.Events;

namespace Nov_4
{
    public class Program
    {

        public delegate void Message(string message);  //delegate here
        static void Main(string[] args)
        {
            var sample = new { name = "Sam", age = 23, college = "CEP", course = new { name = "maths", grade = "A" } };
            //Access from here itself
            Console.WriteLine("sample from without accessing class");
            Console.WriteLine(sample.name);
            Console.WriteLine(sample.age);
            Console.WriteLine(sample.college);
            Console.WriteLine("\n sample,nested from without accessing class");
            Console.WriteLine(sample.course.name);
            //Acces method from anonymous class
            Console.WriteLine("\n sample from accessing class method");
            Anonymous.Print(sample);


            //-----------------------------------------------------------------------------
            //Delegates
            ////string one = "Here we go 1st message";
            ////string two = "2nd message";

            Delegates messages = new Delegates();  // No need if its a static class
            Message message_1 = new Message(messages.Print);

            //Multicast delegate - paramter should be same
            // can use - to delete a multicast
            message_1 += new Message(messages.Print2);

            
            message_1.Invoke("Here we go 1st message");  //Invoke method
            message_1("2nd message");

            //-------------------------------------------------------------------------------------
            //Events

            //Events events = new Events();
            //events.TestEventHandler += Events_TestEventHandler;
            //Console.WriteLine("Enter Colours of RGB");
            //Console.WriteLine("Only 4 chances");
            //int value = 0;
            //while (value <3) {
            //    //var result = Console.ReadKey(true).KeyChar; break;
            //    var colour = Console.ReadLine();
            //    if(colour.ToLower() == "red" || colour.ToLower() == "green" || colour.ToLower() == "blue")
            //    {
            //        Console.WriteLine(value);
            //        value++;
            //        events.Update();

            //    }

            //}


            Console.ReadLine();
        }

        //private static void Events_TestEventHandler(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Events_TestEventHandler(object sender, EventArgs e)
        //{
        //    Console.WriteLine("All colours have been written");
        //}

        private static void Events_TestEventHandler(object sender, ColourSpectrum e)
        {
            Console.WriteLine(e.spectrum.ToString());
            Console.WriteLine("All colours have been written");

        }
    }
}
