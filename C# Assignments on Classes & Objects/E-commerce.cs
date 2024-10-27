using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssign2
{
    public class Products
    {
        //        Assignment 7: E-commerce System
        //        Problem Statement: Design an e-commerce system that manages products and orders.Each
        //        product has a name, price, and stock quantity.Implement methods to create an order that reduces
        //        stock quantity.Implement getters and setters to ensure that the price cannot be negative and the
        //        stock cannot be less than zero

        public string Name;
        private int stock;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Less than zero _ stock");
                }
                else
                {
                    stock = value;
                }
            }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Less than zero _ stock");
                }
                else
                {
                    price = value;
                }
            }
        }

        public Products(string name, int stock, int price)
        {
            this.Name = name;
            this.stock = stock;
            this.price = price;
        }

        public Products(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name:{Name},Stock:{Stock}, Price:{Price}";
        }
    }

    public class Orders
{
    private static List<Products> orders = new List<Products>();

    public void AddOrder(Products product)
    {
        if (product.Stock <= 0)
        {
            throw new ArgumentException("Cannot place an order for an out-of-stock product.");
         }
            else {
                orders.Add(product);
                Console.WriteLine("Order made for product " + product.Name);
                product.Stock -= 1;

            }
            
    }

    public void UpdateProduct(string productName, int? stock = null, int? price = null)
    {
        var productToUpdate = orders.Find(p => p.Name == productName);

        if (productToUpdate == null)
        {
            throw new ArgumentException("Product not found.");
        }

        if (stock.HasValue)
        {
            productToUpdate.Stock = stock.Value;
        }

        if (price.HasValue)
        {
            productToUpdate.Price = price.Value;
        }
    }

        public void ListOrders()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders");
            }
            else
            {
                foreach (var product in orders)
                {
                    Console.WriteLine(product);
                }
            }
        }
}
}
