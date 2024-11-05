using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Oct24
{
    public class Extension
    {
        public void CarCompany(string comp)
        {
            Console.WriteLine(comp);
        }

        public void CarName(string name)
        {
            Console.WriteLine(name);

        }

        public void CarColour(string color)
        {
            Console.WriteLine(color);
        }
    }

    static class Owner  // static
    {
        public static void CarOwner(this Extension example, string owner)  //must be static
        {
            Console.WriteLine(owner);
        }
    }
}
