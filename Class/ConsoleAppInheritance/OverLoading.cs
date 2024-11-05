using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    public class OverLoading
    {

        public void Details(string name)
        {
            Console.WriteLine(name);
        }

        public void Details(string name,int age)
        {
            Console.WriteLine("Nme: "+ name  +" Age: " + age);
        }

        public void Details(string name, string location)
        {
            Console.WriteLine("Name: " + name + " Live: " + location);
        }

        public void Details(string name, int age, string location)
        {
            Console.WriteLine("Nme: " + name + " Age: " + age + " Live: " + location);
        }
    }
}
