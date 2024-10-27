using ConsoleAppAssign2;
using static ConsoleAppAssign2.Bank_21;
using static ConsoleAppAssign2.University;


public class Program
{
    //Assign1
    public static void Main(string[] args)
    {
        //    try
        //    {
        //        Circle circle = new Circle();
        //        circle.Radius = -35;
        //        Console.WriteLine("The radius of the circleis " + circle.Radius);
        //        Console.ReadLine();
        //    }
        //    catch (
        //    ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }



        //-------------------------------------------------------------------------


        //Assign2

        //
        //    try
        //    {
        //        Employee employee = new Employee();
        //        employee.Salary = -35;
        //        Console.WriteLine("The employee's salary is " + employee.Salary);
        //        Console.ReadLine();
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //

        //-------------------------------------------------------------------------

        //Assign3


        //Book book_One = new Book("Kite Runner", "Khalid", "123-1000");
        //Book book_Two = new Book("No longer Human", "Dasai", "123-8900");
        //Book book_Three = new Book("Chcolate Factory", "Stephen", "123-4539");
        //Library library = new Library();

        //library.AddBook(book_One);
        //library.AddBook(book_Three);

        //library.DisplayAll();

        //library.RemoveBook("123-4539");
        //library.DisplayAll();
        //Console.ReadLine();

        //-------------------------------------------------------------------------

        //Assign4


        //try
        //{
        //    Bank bank = new Bank("1000", "ramesh");
        //    bank.Deposit(1000);
        //    bank.Withdraw(1500);
        //    Console.ReadLine();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //-------------------------------------------------------------------------

        //Assign5

        //Students student_One = new Students("Aiha", 1);
        //student_One.AddGrade(23.00);
        //student_One.AddGrade(90.00);
        //student_One.AddGrade(30.00);

        //student_One.Average();

        //Console.ReadLine();

        //-------------------------------------------------------------------------

        //Assign6

        //Items item1 = new Items("Laptop", 3, 45000);
        //Items item2 = new Items("Mouse", 5, 25000);
        //Items item3 = new Items("Keyboard", 9, 5000);
        //Items item4 = new Items("CPU", 1, 425000);

        //Console.WriteLine("--------------");

        //Inventory inventory = new Inventory();
        //inventory.Add(item1);
        //inventory.Add(item2);
        //inventory.Add(item3);
        //inventory.Add(item4);

        //Console.WriteLine("--------------");

        //inventory.DisplayAll();

        //Console.WriteLine("--------------");

        //inventory.Remove(item3);

        //Console.WriteLine("--------------");

        //inventory.DisplayAll();

        //Console.WriteLine("--------------");

        //inventory.UpdateItem("Mouse", 5, 2000);

        //inventory.DisplayAll();
        //Console.WriteLine("--------------");

        //Console.ReadLine();

        //-------------------------------------------------------------------------


        //Assign7
        //Products product1 = new Products("Laptop", 10, 1000);
        //Products product2 = new Products("Smartphone", 5, 500);
        //Products product3 = new Products("Headphones", 15, 100);




        //Orders ManageOrd = new Orders();


        //try
        //{
        //    ManageOrd.AddOrder(product1);
        //    ManageOrd.AddOrder(product2);
        //    ManageOrd.AddOrder(product3);
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        //}



        //ManageOrd.UpdateProduct("Smartphone", stock: 3, price: 450);


        //Console.WriteLine("Updated Products After Order and Changes:");
        //ManageOrd.ListOrders();

        //-------------------------------------------------------------------------

        //Assign8

        //Print value = new Print();
        //Console.WriteLine("Name: " + value.Return("sam"));
        //Console.WriteLine("-------");
        //Console.WriteLine("Number: " + value.Return(3));
        //Console.WriteLine("-------");

        //int[] numbers = { 1, 2, 3, 4, 5 };
        //Console.WriteLine("Return array");
        //value.Return(numbers);

        //Console.ReadLine();

        //-------------------------------------------------------------------------

        //Assign9
        //Rectangle area = new Rectangle();
        //Console.WriteLine("Area of rectangle is ");
        //Console.WriteLine(area.CalculateArea(2, 3));

        //Console.WriteLine("Area of square is ");
        //Console.WriteLine(area.CalculateArea(5));

        //Console.ReadLine();

        //-------------------------------------------------------------------------

        //Assign10
        //Time time = new Time();
        //time.SetTime(2, 45);
        //time.DisplayTime();

        //time.SetTime(500);
        //time.DisplayTime();

        //Console.ReadLine();

        //----------------------------------------------------------------------------------------------------

        //Assign11
        //Bank_11 account_1 = new Bank_11(14521.00);
        //Console.WriteLine("Printing the Balance");
        //account_1.DisplayBalance();
        //Console.WriteLine("-------");
        //Console.WriteLine("Printing the interest");
        //Bank_11.DisplayInterest();
        //Console.WriteLine("-------");
        //Console.ReadLine();

        //---------------------------------------------------------------------------------------------------

        //Assign12
        //Car car_1 = new Car("qwe");
        //Car car_2 = new Car("rty");
        //Car car_3 = new Car("uio");
        //Console.WriteLine("The times added is " + Car.Counter);
        //Console.ReadLine();

        //-----------------------------------------------------------------------------------------------------

        ////Assign13
        //Console.WriteLine(MathOperations.Pi);

        //------------------------------------------------------------------------------------------------------

        //Assign14
        //Configuration config = new Configuration("Max", "Windows");
        //config.Print();
        //Console.ReadLine();

        //-----------------------------------------------------------------------------------------------------

        //Assign15
        //Copy student_1 = new Copy("Maxwell", "1", 8, "A", 15);
        //Copy student_3 = student_1;              //Assigning but same memory

        //Copy student_2 = new Copy(student_1);    //Diff mem location

        //Console.WriteLine("Displaying original");
        //student_1.DisplayAll();
        //Console.WriteLine("Displaying Copied");
        //student_2.DisplayAll();
        //Console.WriteLine("Displaying Assigned");
        //student_3.DisplayAll();

        //Console.WriteLine();
        //Console.WriteLine("Changes made in original");
        //student_1.Student_Name = "Parvathy";
        //Console.WriteLine();
        //Console.WriteLine("Change made in assigned");
        //student_3.Student_Grade = 2;

        //Console.WriteLine();
        //Console.WriteLine("Displaying original");
        //student_1.DisplayAll();
        //Console.WriteLine("Displaying Copied");
        //student_2.DisplayAll();
        //Console.WriteLine("Displaying Assigned");
        //student_3.DisplayAll();

        //Console.ReadLine();

        //-----------------------------------------------------------------------------------------------------
        //Assign16
        //Car2 example1 = new Car2("Corolla");

        //example1.DisplayAll();
        //Console.WriteLine("----------------------------------");

        //Car2 example2 = new Car2("Corolla", "V8");

        //example2.DisplayAll();
        //Console.WriteLine("----------------------------------");


        //Car2 example3 = new Car2("Corolla", "V8", 2017);

        //example3.DisplayAll();
        //Console.WriteLine("----------------------------------");


        //Car2 example4 = new Car2("Corolla", "V8", 2017, 120000);

        //example4.DisplayAll();
        //Console.WriteLine("----------------------------------");
        //-------------------------------------------------------------------------------------------------------

        //Assign17

        //Product_17 item1 = new Product_17("Maxi Dress");
        //Product_17 item2 = new Product_17("Jeans", 350);
        //Product_17 item3 = new Product_17("T-shirt", 240, 50);

        //item1.DisplayAll();
        //Console.WriteLine("----------------------------------");
        //item2.DisplayAll();
        //Console.WriteLine("----------------------------------");
        //item3.DisplayAll();
        //Console.WriteLine("----------------------------------");
        //Console.ReadLine();

        //-------------------------------------------------------------------------------------------------------
        //Assign 18


        //Product_18 object1 = Product_18.CreateObject("Jeans", 345, "Clothes");
        //Console.WriteLine("Using static method init");
        //Console.WriteLine($"Name:{object1.Name}, Price : {object1.Price}, Category : {object1.Category}");

        //Type object2 = typeof(Product_18);
        //var refExample = (Product_18)Activator.CreateInstance(object2);

        //refExample.Name = "Test";
        //refExample.Price = 100;
        //refExample.Category = "SampleTest";
        //Console.WriteLine("Using reflection init");
        //Console.WriteLine($"Name:{refExample.Name}, Price : {refExample.Price}, Category : {refExample.Category}");

        //Product_18 object3 = new Product_18();
        //Console.WriteLine($"Name:{object3.Name}, Price : {object3.Price}, Category : {object3.Category}");

        //Product_18 object4 = new Product_18 { Name = "Test2",Price = 3000, Category = "Object Init" };
        //Console.WriteLine($"Name:{object4.Name}, Price : {object4.Price}, Category : {object4.Category}");

        //var anonymous = new { Name = "Test3", Price = 3000, Category = "Anonymous Init" };
        //Console.WriteLine($"Name:{anonymous.Name}, Price : {anonymous.Price}, Category : {anonymous.Category}");

        //Console.ReadLine();


        //-------------------------------------------------------------------------------------------------------

        //Assign20
        //ShoppinCart cart = new ShoppinCart();
        //ShoppinCart.Products item1 = new ShoppinCart.Products("Apple",35,2);
        //ShoppinCart.Products item2 = new ShoppinCart.Products("Kiwi", 20, 5);


        //cart.AddProducts(item1);
        //cart.AddProducts(item2);

        //cart.TotalPrice();


        //Console.ReadLine();
        //-------------------------------------------------------------------------------------------------------
        //Bank_21 bank = new Bank_21();
        //Customer customer1 = new Customer("Doe");
        //Customer customer2 = new Customer("Smith");
        //bank.AddCustomer(customer1);
        //bank.AddCustomer(customer2);

        //// Adding accounts for customers
        //bank.AddAccount_Main(customer1, "6789", 00.0);
        //bank.AddAccount_Main(customer2, "4321", 1000.0);
        //bank.AddAccount_Main(customer1, "4453", 50.0);  // Another account for John Doe

        //// Display all customers and their accounts
        //bank.DisplayAll();

        //Console.ReadLine();

        //--------------------------------------------------------------------------------------------------

        //Assign22
        University university = new University();

        Department csDepartment = new Department("Computer Science");
        Department mathDepartment = new Department("Mathematics");
        university.AddDepartment(csDepartment);
        university.AddDepartment(mathDepartment);

        // Adding courses to departments
        university.AddCourses_Main(csDepartment, "Data Structures", "CS101");
        university.AddCourses_Main(csDepartment, "Algorithms", "CS102");
        university.AddCourses_Main(mathDepartment, "Calculus", "MATH101");

        // Display all departments and their courses
        university.DisplayAll();

        Console.ReadLine();



    }
} 