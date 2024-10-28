using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polymorphism.Lab_7_example;
using static Polymorphism.Lab_9_interface;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Assignment -1
            //For each shape object type is changed
            //Shape_1 shape1 = new Shape_1();
            //shape1.Draw_1();

            //Shape_1 shape2 = new Circle_1();
            //shape2.Draw_1();

            //Shape_1 shape3 = new Rectangle_1();
            //shape3.Draw_1();

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Assignment -2
            //Multiply_2 answer = new Multiply_2();
            ////Method overloading
            //answer.Multiply(3);
            //answer.Multiply(4,3);
            //answer.Multiply(5,4.3,6.2);
            //answer.Multiply(4.3, 5, 6.2);
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Assignment -3

            //Type of object changes
            //Vehicle_3 car = new Vehicle_3();
            //car.Drive();

            //Vehicle_3 car2 = new Car_3();
            //car2.Drive();
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Assignment -4

            //Type of object changes
            //Payment_4 pay1 = new Payment_4();
            //pay1.ProcessPayment();

            //Payment_4 pay2 = new Bank_4();
            //pay2.ProcessPayment();

            //Payment_4 pay3 = new Server_4();
            //pay3.ProcessPayment();

            //Payment_4 pay4 = new Credit_4();
            //pay4.ProcessPayment();

            //Payment_4 pay5 = new PayPall_4();
            //pay5.ProcessPayment();

            //Payment_4 pay6 = new Complete_4();
            //pay6.ProcessPayment();

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Assignment -5
            //Manager_5 manager = new Manager_5(3);
            //Developer_5 developer = new Developer_5(5);

            //manager.DisplayInfo_5();
            //developer.DisplayInfo_5();

            //Employee_5 employee = new Employee_5();
            //employee.DisplayInfo_5();
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Assignment -6
            //string[] managerTasks = { "Planning", "Supervising", "Reviewing" };
            //string[] developerTasks = { "Coding", "Testing", "Debugging" };

            //// Creating objects of Manager and Developer
            //Employee_6 manager = new Manager_6("Alice", managerTasks);
            //Employee_6 developer = new Developer_6("Bob", developerTasks);

            //// Display tasks
            //manager.DisplayTask();
            //developer.DisplayTask();

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------
            //Assignmnet -7

            // Early Binding Example
            //Console.WriteLine("Early Binding - Method Overloading:");
            //Printer printer = new Printer();
            //printer.Print("Hello, World!");
            //printer.Print(123);

            //Console.WriteLine();

            //// Late Binding Example
            //Console.WriteLine("Late Binding - Method Overriding:");
            //Animal myDog = new Dog();


            //myDog.Speak();  // Call Dog Speak
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------
            //Assignmnet -8

            //Derive_1 interface_example_1 = new Derive_1();
            //interface_example_1.Shape();

            //Derive_2 interface_example_2 = new Derive_2();
            //interface_example_2.Shape();
            //Console.ReadLine();


            //--------------------------------------------------------------------------------------------
            //Assignmnet -9

            //Car myCar = new Car();

            //// Demonstrating multiple inheritance
            //myCar.Move();    // Calls Move - IMovable
            //myCar.Draw();    // Calls Draw - IDrawable
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------
            //Assignmnet -10

            //// Creating instances of Teenager and Adult
            //Lab_10_ReadOnly teenager = new Teenager("Alice");
            //Lab_10_ReadOnly adult = new Adult("Bob");

            //// Demonstrating polymorphism with readonly property
            //teenager.Details();
            //adult.Details();
            //Console.ReadLine();

        }

    }
}
