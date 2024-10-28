using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Lab5
    {
        /*Lab 5. Hybrid Inheritance(Using Interfaces)
        Hybrid inheritance combines multiple types of inheritance.Since C# doesn't support direct
        multiple inheritance, hybrid inheritance is implemented using interfaces.*/

        //Problem:
        //Create two interfaces IMovable and IRechargeable.
        interface IMovable
        {
            void Move();
        }
        interface IRechargeable
        {
            void Recharge();
        }

        //Create a class Vehicle implementing
        public class Vehicle : IMovable , IRechargeable
        {
            public void Move() {
                Console.WriteLine("Movable from IMovable");
            }

            public void Recharge() {
                Console.WriteLine("Recharge from IRechageable");
            }
            //IMovable and derive ElectricCar from Vehicle implementing both interfaces.

            public void ElectricCar()
            {
                Console.WriteLine("Implementing both functions in Electric car function");
                Recharge();
                Move();
            }

        }

    }
}
