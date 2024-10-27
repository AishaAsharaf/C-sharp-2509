using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppAssign2
{
    public class Product_17
    {
        //Assignment 17: Understanding the Need for Constructor Overloading
        //Problem Statement:
        //Write a C# program that models a Product class with overloaded constructors. The class should:
        //1. Provide flexibility in product initialization based on the availability of price and discount
        //information.
        //2. Use constructor overloading to handle cases where only basic product information is
        //available, as well as cases where detailed information(price and discount) is provided.


        //Tasks:
        //1. Create a class named Product with the following:
        //o Fields for name, price, and discount.
        //o Three constructors:
        // A constructor that initializes only the name.
        // A constructor that initializes name and price.
        // A constructor that initializes name, price, and discount.
        //2. Implement a method CalculateFinalPrice() that computes the final price after applying
        //the discount (if applicable).
        //3. In the Main() method:
        //o Create different Product objects using various constructors.
        //o Display the details of each product, including the final price after any applicable
        //discount

        public string productName;
        public double productPrice;
        public double Discount;

        public Product_17(string name)
        {
            this.productName = name;
            this.productPrice = 0;
            this.Discount = 0;
        }

        public Product_17(string name, double price)
        {
            this.productName = name;
            this.productPrice = price;
            this.Discount = 0;
        }
        public Product_17(string name, double price,int discount) 
        {
            this.Discount = discount;
            this.productName = name;
            this.productPrice = price;
        }

        public double CalculateFinalPrice() {
            
            double result = productPrice-productPrice * (Discount / 100);
            return result;
        
        }
        public void DisplayAll()
        {
            Console.WriteLine($"Name : {productName}, Price : {productPrice}, Discount in Percentage : {Discount} , Final : {CalculateFinalPrice()}");
        }


    }
}
