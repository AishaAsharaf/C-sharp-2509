using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Items
    {
        //Assignment 6: Inventory System
        //Problem Statement: Create an inventory management system that manages items in a store.
        //Each item has a name, stock, and price. Implement methods to add, remove, and update items.
        //Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a
        //negative value.
        public string Name;
        private int stock;
        private double price;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
                else
                {
                    Console.WriteLine("Stock value not positive");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price value not positive");
                }
            }
        }


        public Items(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }

        public override string ToString()
        {
            return $"Item: {Name}, Stock: {Stock}, Price: {Price}";
        }


    }

    public class Inventory
    {
        public static List<Items> items = new List<Items>();

        public void Add(Items item)
        {
            items.Add(item);
            Console.WriteLine("Item Added");

        }

        public void Remove(Items item)
        {
            items.Remove(item);
            Console.WriteLine("Item removed");

        }
        public void UpdateItem(string name, int? stock = null, double? price = null)
        {
            Items ItemToUpdate = null;

            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    ItemToUpdate = item;
                }
            }

            if (ItemToUpdate == null)
            {
                throw new ArgumentException("Not Found");
            }

            if (stock.HasValue)
            {
                ItemToUpdate.Stock = stock.Value;
            }

            if (price.HasValue)
            {
                ItemToUpdate.Price = price.Value;
            }
        }





        public void DisplayAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
