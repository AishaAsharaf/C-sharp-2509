using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Product_18
    {
        //Assignment 18: Exploring Different Ways to Initialize Objects
        //Problem Statement:
        //Write a C# program that demonstrates different ways to initialize an object of a class. The class
        //should represent a Product with properties such as Name, Price, and Category.Implement the
        //following methods of object initialization:
        //1. Constructor initialization.
        //2. Object initializer syntax.
        //3. Static factory method.
        //4. Anonymous types.
        //5. Reflection.
        //6. Default values in constructors.


        //Tasks:
        //1. Create a class named Product with the following:
        //o Properties for Name, Price, and Category.
        //o A constructor that initializes all three properties.

        //o A static method to create a Product object.
        //o Use reflection to dynamically create a Product object.
        //o Implement a constructor that provides default values for the properties.

        //2. In the Main() method:
        //o Create instances of the Product class using the different initialization techniques
        //mentioned above.
        //o Display the details of each product.

        public string Name;
        public double Price;
        public string Category;

        public Product_18(string productName, double price, string category)
        {
            this.Name = productName;
            this.Price = price;
            this.Category = category;
        }

        public Product_18()
        {
            this.Name = "Unknown";
            this.Price = 00.00;
            this.Category = "Unknown";
        }

        public static Product_18 CreateObject(string productName, double price, string category)
        {
            return new Product_18 { Name =productName , Price = price, Category = category};
        }
    }
}
