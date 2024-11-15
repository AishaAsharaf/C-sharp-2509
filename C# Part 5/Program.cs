using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Web.UI;
using System.Xml.Linq;

namespace C_Assignments_SolutionsPart_5
{
    public class Program
    {
        public static readonly string filepath = @"C:\Users\aisha\source\repos\Log4Net_example\los.txt";


        static void Main(string[] args)
        {
            ////Assign-1

            ////Book array - 1D
            //string[] book = { "No longer Human", "Kite Runner", "Little Things", "HarryPotter" };
            //Library library = new Library(book);
            //library.DisplayBooks();

            ////Seats array -2D

            //int[,] seats = {
            //{ 1, 5},
            //{ 1, 2},
            //{ 1, 4}
            // };
            //Classroom classroom = new Classroom(seats);
            //classroom.DisplaySeats();


            //Console.ReadLine();

            //--------------------------------------------------
            ////Assign-2
            //Create a MovieLibrary with an initial capacity of 3
            //MovieLibrary movieLibrary = new MovieLibrary(3);

            //// Create Movie objects and add them to the library
            //movieLibrary.AddMovie(new Movie("Inception", "2010"));
            //movieLibrary.AddMovie(new Movie("The Matrix", "1999"));
            //movieLibrary.AddMovie(new Movie("Interstellar", "2014"));

            //// Display all movies in the library
            //movieLibrary.DisplayMovies();
            //Console.ReadLine();
            //----------------------------------------------------------
            ////Assignment 3
            // Instantiate the Order object
            //Order order = new Order();

            //// Set the status of the order
            //order.Type = Order.OrderStatus.Shipped;

            //// Call the OrderStatusView method to display the status
            //order.OrderStatusView();
            //Console.ReadLine();

            //---------------------------------------------------------
            //Assignment 4

            //Circle circle_struct_1 = new Circle(24);
            //Circle circle_struct_2 = circle_struct_1;  //copy struct

            //Console.WriteLine($"x equal to circle1 {circle_struct_1.X}");
            //Console.WriteLine($"x equal to circle2 {circle_struct_2.X}");

            //circle_struct_2.X = 40;  //copy struct value change

            //Console.WriteLine($"x equal to after change in circle 2 {circle_struct_2.X}");  //value change
            //Console.WriteLine($"x equal to after change in circle 1 {circle_struct_1.X}");  //value same

            //Shape shape1 = new Shape("aradhya");
            //Shape shape2 = shape1;  //copy class
            //Console.WriteLine($"Shape 1 name {shape1.Name}");
            //Console.WriteLine($"Shape 2 name {shape2.Name}");

            //shape2.Name = "Haana";
            //Console.WriteLine($"Shape 2 name after change {shape2.Name}"); //new value
            //Console.WriteLine($"Shape 1 name after change {shape1.Name}");  // new value

            //Console.ReadLine();

            //---------------------------------------------------------
            //Assignment 5
            //RefExample example = new RefExample();
            //int score1 = 0 ;
            //example.IncreaseScore(ref score1);

            //Console.ReadLine();
            //---------------------------------------------------------
            //Assignment 6
            //int numberOne = 10;
            //int numberTwo = 20;
            //int quotient ;               //init values here but not posssible for ref
            //int remainder ;


            //OutParameter example = new OutParameter();
            //example.Divide(numberOne, numberTwo, out remainder, out quotient);

            //Console.WriteLine("Dividend: " + numberTwo);
            //Console.WriteLine("Divisor: " + numberOne);
            //Console.WriteLine("Quotient: " + quotient);
            //Console.WriteLine("Remainder: " + remainder);

            //Console.ReadLine();
            //----------------------------------------------------------
            //Assignment 7
            //file path stored in variable
            //string filepath = "C:\\Users\\aisha\\source\\repos\\C#Assignments-SolutionsPart-5\\nofile.txt";

            //try
            //{
            //    /* string text = 
            //    File.ReadAllText(filepath);  //read file in one string
            //}
            //catch (FileNotFoundException)  //exception
            //{

            //    Console.WriteLine("File not found in specified location");
            //}

            //finally
            //{
            //    Console.WriteLine("File fetch completed");
            //}

            //IndexoutofRange excepyion example

            //int[] numbers = { 1, 2, 3, 4 };
            //try
            //{
            //    for (int i = 0; i < 7; i++)
            //    {
            //        Console.WriteLine(numbers[i]);  //only has lenght of 4
            //    }
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index out of range exception found");
            //}
            //finally
            //{
            //    Console.WriteLine("Looped thru all numbers");
            //}
            //Console.ReadLine();

            //---------------------------------------------------------------------------

            //Assignment 8
            //while loop to implement this question
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter an integer");
            //        int value = Convert.ToInt32(Console.ReadLine());
            //        break;       //break if its really a integer


            //    }
            //    catch (Exception ex)    //Use formatException
            //    {
            //        Console.WriteLine("Not an integer");   //else catch the error   //Catch -messge-exe

            //    }


            //}
            //Console.WriteLine("It was a integer value");
            //Console.ReadLine();

            //--------------------------------------------------------------------------
            //Assignment 9

            //Division
            //DivideByZeroException and FormatException. 


            //try
            //{
            //    Console.WriteLine("Divident is :");
            //    int divident = Convert.ToInt32(Console.ReadLine());

            //    //In both divident and divisor ,format exception can arise

            //    Console.WriteLine("Divisor is :");
            //    int divisor = Convert.ToInt32(Console.ReadLine());
            //    double result = divident / divisor;
            //    //Divide by zero can arise here
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error : Cannot divide by zero");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error : Formatting issues");
            //}
            //finally     //finally will execute no matter the case
            //{
            //    Console.WriteLine("Completed");
            //}
            //Console.ReadLine();

            ///------------------------------------------------------------------
            ///Assignment 10

            //file path stored in variable


            //StreamReader reader = null; // Initialize the StreamReader variable

            //try
            //{
            //    reader = new StreamReader(filepath); // Open the file   //given the file path above
            //    string content = reader.ReadToEnd(); // Read the contents of the file
            //    Console.WriteLine(content); // Display the content
            //}
            //catch (FileNotFoundException)  //exception
            //{

            //    Console.WriteLine("File not found in specified location");
            //}

            //finally
            //{
            //    reader.Close();    //Close file     //add if condition
            //    Console.WriteLine("File fetch completed");
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------
            //Assignment 11


            //try
            //{
            //    Age_Exception age_sample = new Age_Exception();
            //    age_sample.Age = 12;
            //    Check_Age(age_sample);   //method to check age above 18 or not
            //}
            //catch (Below18 ex)   //exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Completed");
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------
            //Assignment 12

            //try
            //{
            //    NegativeCheck number1 = new NegativeCheck();
            //    Console.WriteLine("Enter a number");
            //    int value = Convert.ToInt32(Console.ReadLine());
            //    number1.number = value;                                          //change
            //    CheckNumber(number1);
            //}
            //catch (NegativeNumberException ex)   //exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //}
            //Console.ReadLine();

            ///------------------------------------------------------------------------
            ///Assignment -13

            //Calling the method using class as it is static method
            //LoggingExample.Divide(10, 0);
            //Console.ReadLine();
            //----------------------------------------------------------------------------
            ///Assignment  15
            ///Task -1
            //string path = @"C:\Users\aisha\source\repos\Log4Net_example\log.txt";
            //FileProcessor file_1 = new FileProcessor();
            //file_1.ReadFileContent(path);

            //Console.ReadLine();
            //Read content method

            //Task-2
            //MathOperations math = new MathOperations();
            //math.Divide(32, 0);

            //Console.ReadLine();

            //Task -3
            Person person = new Person();

            try
            {
                person.SetAge(-5); // This will throw an exception
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            //Task 4

        }
        //Assignment 11
        //private static void Check_Age(Age_Exception age1)  //outside static,onside program,private,static
        //{
        //    if (age1.Age >= 18)  //to check age above 18 or not
        //    {
        //        Console.WriteLine(age1.Age + " is the age so,above or equal to 18");
        //    }
        //    else
        //    {
        //        throw new Below18();    //calls below18 class--exception
        //    }

        //}
        //------------------------------------------------------------------------------------------------
        //Assignment 12
        //private static void CheckNumber(NegativeCheck number_one)
        //{
        //    if (number_one.number >= 0)
        //    {
        //        Console.WriteLine("A positive number is written that is " + number_one.number);
        //    }
        //    else
        //    {
        //        throw new NegativeNumberException();
        //    }
        //}

        //-------------------------------------------------------------------------------------------

        //Assignment 15 -Task 3


    }
}

