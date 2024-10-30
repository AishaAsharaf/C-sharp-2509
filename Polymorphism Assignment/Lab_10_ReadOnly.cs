using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Polymorphism
{
    public class Lab_10_ReadOnly
    {

        //Assignment 10. Polymorphism in C# with Readonly Property
        //Create a C# program that demonstrates polymorphism with a readonly property. Define a base
        //class and derived classes where each class provides specific behavior for a method, while using a
        //readonly property to ensure that certain values cannot be modified after initialization.

        public readonly string Name;   // readonly field can be set once per object instance(note to self)
        public int Age;

        public Lab_10_ReadOnly(string name, int age)
        {
            Name = "Sheela";
            Age = age;
        }

        public virtual void Details()
        {
            Console.WriteLine(Name + " at the age of "+ Age);
        }

    }

    public class Teenager: Lab_10_ReadOnly
    {
        public Teenager(string name,int age) : base(name, age)
        {
            base.Age = age;
            //base.Name = "Sheela"
        }
        
        public override void Details()
        {
            Console.WriteLine(base.Name + " at the age of " + base.Age);
        }
    }

    public class Adult : Lab_10_ReadOnly
    {
        public Adult(string name, int age) : base(name, age)
        {
            base.Age = age;
            //base.Name = "Imen"


        }
        public override void Details()
        {
            Console.WriteLine(base.Name + " at the age of " + base.Age);
        }
    }
}
