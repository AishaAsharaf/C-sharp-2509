using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Assignments__Part_7
{
    public class Program
    {
        //Assign 3
        //Delegate

        public delegate double OperationDelegate(double a, double b);

        //Assign 5
        public delegate void GreetDelegate(string message);

        //Assign_8
        public delegate void StringOperationDelegate(string message);

        //Assign 10
        public delegate int CalculationDelegate(int num1, int num2);

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method for subtraction
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Calculate(int num1, int num2, CalculationDelegate calcDelegate)
        {
            return calcDelegate(num1, num2);  // Perform the calculation using the delegate
        }

        //Assign 13
        public static async Task<int> SumArray(int[] numbers)
        {
            int sum = 0;
            /*return*/ await Task.Run(async () =>
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
                //return sum;
            });
            return sum;

        }

        public static async Task Main(string[] args)   //asyn for 13th
        {   //Assign 1

            //var book = new { title = "Little Things", author = "Prakash", price = 2333.00 };
            //Assign_1 example = new Assign_1();
            //example.Display(book);

            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 2

            //1. Declare a var variable to hold a list of integers, add some numbers to it, and print them.
            //2. Declare a dynamic variable, assign different types of values to it, and observe the
            //behavior

            //var list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //Console.WriteLine("Var as list :");
            //foreach (var item in list) { 
            //    Console.Write(" "+item);

            //}

            //dynamic variable = 0;
            //Console.WriteLine("\nvariable is dynamic: "+ variable);
            //variable = "food";
            //Console.WriteLine("variable : " + variable);
            //variable = 2.3;
            //Console.WriteLine("variable : " + variable);
            //variable = new List<int>();
            //variable.Add(1);
            //variable.Add(2);
            //variable.Add(3);
            //Console.WriteLine("Variable as list :");
            //foreach (var item in variable)
            //{
            //    Console.Write(" " +item);

            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 3

            //Assign_3 math = new Assign_3();
            //OperationDelegate operation1 = new OperationDelegate(math.Add);
            //OperationDelegate operation2 = new OperationDelegate(math.Sub);
            //OperationDelegate operation3 = new OperationDelegate(math.Multiply);
            //OperationDelegate operation4 = new OperationDelegate(math.Division);
            ////operation += new OperationDelegate(math.Sub);
            ////operation += new OperationDelegate(math.Multiply);
            ////operation += new OperationDelegate(math.Division);
            //Console.WriteLine("Enter the first number");
            //double value1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //double value2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter operation  [ +  -  /  *]");
            //string value3 = Console.ReadLine();

            //switch (value3)
            //{
            //    case "+":
            //        operation1.Invoke(value1, value2);
            //        break;
            //    case "-":
            //        operation2.Invoke(value1, value2);
            //        break;
            //    case "*":
            //        operation3.Invoke(value1, value2);
            //        break;
            //    case "/":
            //        operation4.Invoke(value1, value2);
            //        break;
            //    default:
            //        Console.WriteLine("Not + , - ,/ ,*");
            //        break;
            //}


            ////operation.Invoke(10, 2);
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 4

            //Process process = new Process();
            //process.OnCompleted += Process_OnCompleted;       //Publish = Subscribe
            //process.Trigger();
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 5

            //Assign_5 example = new Assign_5();
            //GreetDelegate greet = delegate (string message)//delegate and lambda function
            //{
            //    Console.WriteLine("Helloo !! " + message);

            //};
            //greet("Natasha");
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 6
            //Func<int,int,int> product = (number1, number2) => number1 * number2;  //Func is a delegate type in c#

            //int result = product(4, 6);
            //Console.WriteLine("The product is: " + result);
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 7

            //Expression<Func<int,int,int>> addExpress = (number1, number2) => number1 + number2;

            //Func<int, int, int>  addInteger = addExpress.Compile();

            //int result = addInteger(5, 10);

            //// Output the result
            //Console.WriteLine("The sum is: " + result);
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 8

            //Assign_8 example = new Assign_8();
            //StringOperationDelegate test = new StringOperationDelegate(example.UpperCase);
            //test += new StringOperationDelegate(example.Reverse);

            //test += new StringOperationDelegate(example.AddPrefix);



            //test.Invoke("gorilla");
            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 9
            //Products example = new Products();
            //List<Products> products = new List<Products>
            //{
            //new Products { Name = "Laptop", Price = 1200 },
            //new Products { Name = "Headphones", Price = 150 },
            //new Products { Name = "Smartphone", Price = 800 },
            //new Products { Name = "Keyboard", Price = 40 },
            //new Products { Name = "Mouse", Price = 25 },
            //new Products { Name = "Monitor", Price = 300 }
            //};

            ////Given a list of products with properties Name and Price, use lambda expressions to:
            ////1. Filter the list to find products that cost more than $50.
            //var FilterPrice = products.Where(x => x.Price > 50).ToList();
            //Console.WriteLine("Products price >50");
            //foreach (var product in FilterPrice)
            //{
            //    Console.WriteLine("Name : "+ product.Name + "Price : " + product.Price);

            //}
            //Console.WriteLine("---------------------------------------------------");
            ////2. Sort the list by price in descending order.
            //var  Descending = products.OrderByDescending(x => x.Price).ToList();
            //Console.WriteLine("Products price descending order");
            //foreach (var product in Descending)
            //{
            //    Console.WriteLine("Name : " + product.Name + "Price : " + product.Price);

            //}
            //Console.WriteLine("---------------------------------------------------");
            ////3. Select and display only the names of products from the filtered list. 
            //Console.WriteLine("The name pf products: ");
            //foreach (var product in products) { 
            //Console.WriteLine(product.Name);

            //}

            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 10

            //int number1 = 25;
            //int number2 = 10;
            ////Assign_10 example = new Assign_10();


            //int sum = Calculate(number1, number2, Add );
            //Console.WriteLine("Addition Result: " + sum);  


            //int difference = Calculate(number1, number2, Subtract);
            //Console.WriteLine("Subtraction Result: " + difference);

            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 11

            ////Assign_11 example = new Assign_11();
            ////Console.WriteLine("Start of operation");
            //Assign_11.AsyncMethod();
            ////Console.WriteLine("Main method complete");
            ////Console.WriteLine("End of operation");
            //Console.ReadLine();

            // Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 12
            //string url = "https://jsonplaceholder.typicode.com/posts";

            //Assign_12.DownloadData(url);

            ////Console.WriteLine("Completed ................");

            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 13

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //int result = await SumArray(array);
            //Console.WriteLine("Sum is : " + result);
            //Console.WriteLine("Completed ................");

            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 14

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //try
            //{
            //    int result = await SumArray(array);
            //    Console.WriteLine("Sum is : " + result);
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Completed ................");
            //}


            //Console.ReadLine();
            //----------------------------------------------------------------------------
            //Assign 15

            //int[] numbers = { 12, 15 };

            //// Run the factorial tasks asynchronously
            //await Assign_15.RunFactorialTasksAsync(numbers);
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 16
            //Assignment 16. LINQ Query Syntax and Method Syntax
            //Question: Write a LINQ query using both query syntax and method syntax to retrieve all
            //numbers greater than 5 from a list of integers.
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //var querySyntax = from x in numbers
            //                  where x > 5
            //                  select x;
            //var methodSyntax = numbers.Where(x => x > 5).ToList();

            //Console.WriteLine("Query Syntax Result:");
            //foreach (var number in querySyntax)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nMethod Syntax Result:");
            //foreach (var number in methodSyntax)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------
            //Assign 17
            //Assignment 17.LINQ Operators(Select, Where, GroupBy, Join, etc.)
            //Question 1: Given a list of strings representing student names, write a LINQ query that selects
            //the names starting with the letter 'A' and orders them alphabetically.

            //Assign_17 example = new Assign_17();
            //List<Assign_17> example_List = new List<Assign_17>()
            //{
            //    new Assign_17() {name = "Alexander",id =2 },
            //    new Assign_17() {name = "Zafreen",id =3 },
            //    new Assign_17() {name = "Aleesha",id =1 },
            //    new Assign_17() {name = "Imen",id =4 },
            //    new Assign_17() {name = "Aisha",id =5 }
            //};

            //var selectOrder = from x in example_List
            //                  where x.name.StartsWith("A")
            //                  orderby x.name
            //                  select x.name;

            //var selectOrderMethod = example_List
            //                    .Where(x => x.name.StartsWith("A"))
            //                    .OrderBy(x => x.name)
            //                    .Select(x => x.name)
            //                    .ToList();

            //Console.WriteLine("Query Syntax Result:");
            //foreach (var name in selectOrder)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("\nMethod Syntax Result:");
            //foreach (var name in selectOrderMethod)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();
            //-----------------------------------------------------------------------------
            //Assign_18
            //Assignment 18. LINQ to Objects
            //Question: Write a LINQ query to find the sum of all even numbers in an array of integers.

            int[] numbers = { 2, 3, 1, 4, 6, 4, 32, 78, 34 };
            //var SumEven = from x in numbers
            //              where x%2 == 0
            //              select x;

            var SumEven = numbers.Where(x=>x%2==0).Sum();
            Console.WriteLine("Sum is: " + SumEven);
            Console.ReadLine();
            //-----------------------------------------------------------------------------
            //Assign_19
            //Assignment 19.LINQ to XML
            //Question: Create an XML document representing a list of books, and use LINQ to XML to
            //query the titles of books published after 2015.

            //XElement books = new XElement("Books",
            //new XElement("Book",
            //    new XElement("Title", "Little Things"),
            //    new XElement("Author", "Fancis"),
            //    new XElement("PublishedYear", 2014)
            //),
            //new XElement("Book",
            //    new XElement("Title", "KIte Runner"),
            //    new XElement("Author", "Khalid"),
            //    new XElement("PublishedYear", 2017)
            //)
            //);

            
            //var booksPublishedAfter2015 = books.Elements("Book")
            //                                   .Where(book => (int)book.Element("PublishedYear") > 2015)
            //                                   .Select(book => book.Element("Title").Value);

            //Console.WriteLine("Books published after 2015:");
            //foreach (var title in booksPublishedAfter2015)
            //{
            //    Console.WriteLine(title);
            //}
            //Console.ReadLine();
            //-------------------------------------------------------------------------------------------------
            //Assign 20
            //Assignment 20.LINQ to SQL
            //Question: Given a database table Employees with columns ID, Name, and Department, write a
            //LINQ to SQL query to select all employees from the "IT" department.

            //List<Employee> employees = new List<Employee>
            //{
            //new Employee { ID = 1, Name = "John Doe", Department = "IT" },
            //new Employee { ID = 2, Name = "Jane Smith", Department = "HR" },
            //new Employee { ID = 3, Name = "Alice Johnson", Department = "IT" },
            //new Employee { ID = 4, Name = "Bob Brown", Department = "Finance" }
            // };

            //// LINQ query to select employees from the IT department
            //var itEmployees = employees.Where(employee => employee.Department == "IT").ToList();

            //// Display the results
            //Console.WriteLine("Employees in the IT department:");
            //foreach (var employee in itEmployees)
            //{
            //    Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}");
            //}
            //Console.ReadLine();
        }

        private static void Process_OnCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("\nProcess completed!");
        }
    }
}
