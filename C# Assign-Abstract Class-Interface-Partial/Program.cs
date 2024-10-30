using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Interface_Partial.Assignment_12;
using static Abstract_Interface_Partial.Assignment_3;

namespace Abstract_Interface_Partial
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ////Assignment 1
            ////Access car
            //Car car = new Car();
            //car.StartEngine();
            ////Access base method
            //car.StopEngine();

            //Motorcycle motorcycle = new Motorcycle();
            //motorcycle.StartEngine();
            //motorcycle.StopEngine();

            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assignment 2

            //Animal animal = new Animal();
            //animal.MakeSound();

            //Animal cat = new Cat();
            //cat.MakeSound();

            //Animal dog = new Dog();
            //dog.MakeSound();
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            //Assignment 3
            // Car class
            //Car_3 car = new Car_3();
            //Truck_3 truck = new Truck_3();

            //car.Drive();
            //truck.Drive();

            //Console.ReadLine();
            //----------------------------------------------------------------------------

            //Assignment 4

            //BirdChild child1 = new BirdChild();
            //child1.Fly();

            //SwimChild child2 = new SwimChild();
            //child2.Swim();
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            ////Assignment 5
            ////Calling a static method in static class
            //Console.WriteLine($"The sum is {MathOperations.Add(2,4)}");
            //Console.WriteLine($"The product is {MathOperations.Multipy(2, 4)}");
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            ////Assignment 6
            //Assignment_6 assign = new Assignment_6();
            //assign.Number(9);

            //assign.IsEven();
            //Console.ReadLine();


            //----------------------------------------------------------------------------

            ////Assignment 7
            ///Example for Partial class
            //Assign_7 example = new Assign_7("Soha",23,"BPS","CEP","Quest");
            //example.ShowDetails();
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            ////Assignment 8
            ///Partial method available in higher versions only so skipped 
            ///
            //----------------------------------------------------------------------------

            ////Assignment 9

            //Library library = new Library();
            ////Assigning values
            //library[0] = "No longer Human";
            //library[1] = "Little Things";
            //library[2] = "Fault in our Stars";
            //library[3] = "Kite Runner";
            //library[4] = "The world is young";

            ////Display all books in library
            //library.DisplayAll();
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            //////Assignment 10

            //Assignment_10 number = new Assignment_10();
            //try
            //{
            //    number.Divide(4, 0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{
            //    Console.WriteLine("Division Completed");
            //}

            //Console.ReadLine();

            //----------------------------------------------------------------------------

            ////Assignment 11

            //create instance
            //Car_11 car = new Car_11();
            //// Set the car type
            //car.Type = Car_11.CarType.SUV;

            //// Call the DisplayEnum method with the car type
            //car.DisplayEnum(car.Type);

            //Console.ReadLine();

            //----------------------------------------------------------------------------

            ////Assignment 12
            //


            //instance of Calculator 
            Calculator calc = new Calculator();

            // Get-display attribute info-Calculator class
            var classAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(typeof(Calculator), typeof(DeveloperAttribute));
            Console.WriteLine($"Class Dev: {classAttribute.Name}, Last Modified: {classAttribute.Date}");

            // Get-display attribute info-Add method
            var methodAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(typeof(Calculator).GetMethod("Add"), typeof(DeveloperAttribute));
            Console.WriteLine($"Method Dev: {methodAttribute.Name}, Last Modified: {methodAttribute.Date}");
            
            //add method
            calc.Add(5, 10);
            Console.ReadLine();

        }
    }
}
