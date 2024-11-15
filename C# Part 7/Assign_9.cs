using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Products
    {
        //Assignment 9. Lambda Expressions to Filter and Process Lists
        // Question:
        //Given a list of products with properties Name and Price, use lambda expressions to:
        //1. Filter the list to find products that cost more than $50.
        //2. Sort the list by price in descending order.
        //3. Select and display only the names of products from the filtered list. 

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
