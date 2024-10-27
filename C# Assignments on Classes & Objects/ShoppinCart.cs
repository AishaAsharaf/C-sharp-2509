using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssign2
{
    public class ShoppinCart
    {
        //Assignment 20: Shopping Cart
        //Problem Statement:
        //You need to create a Shopping Cart class that holds a list of Product objects.The Product class
        //will be a nested class. The system should allow users to add products to the cart and display the
        //total price.

        //Tasks:

        //1. Create a ShoppingCart class that contains:
        //o A list of Product objects.
        //o Methods to add products and calculate the total price.

        //2. Create a nested Product class with properties for Name, Price, and Quantity.

        //3. Demonstrate adding products and displaying the total price in the Main() method.
        
        public static List<ShoppinCart.Products> cart = new List<ShoppinCart.Products>();
        public void AddProducts(ShoppinCart.Products product)
        {
            cart.Add(product);
            Console.WriteLine($"Name : {product.Name},Price : {product.Price}, Quantity : {product.Quantity}");
            Console.WriteLine("Added item");
        }

        public void TotalPrice()
        {
            double sum = 0;
            foreach (var product in cart) {
                sum =+ product.Price * product.Quantity;
            }
            Console.WriteLine("The total price is " + sum);
        }
        

        public class Products
        {
            public string Name;
            public double Price;
            public int Quantity;

            public Products(string name, double price, int quantity) {
                   this.Name = name;
                   this.Price = price;
                   this.Quantity = quantity;
            
            }

            public void DisplayAll()
            {
                Console.WriteLine($"Name : {Name},Price : {Price}, Quantity : {Quantity}");
            }
           
        }


    }
}
