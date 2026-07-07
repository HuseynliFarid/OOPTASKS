using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace OOPTASKS.src
{
    public  class  Product
    {
        public string Name;
        private double price; // Private field to store the price
        private int stockCount; // Private field to store the stock count

        public double Price // Public property to access the price
        {
            get // Getter method to retrieve the price
            {
                return price;
            }
            set // Setter method to set the price with validation
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Invalid price. Setting to 0.");
                    price = 0;
                }
            }
        }
        public int StockCount // Public property to access the stock count
        {
            get // Getter method to retrieve the stock count
            {
                return stockCount;
            }
            set // Setter method to set the stock count with validation
            {
                if (value >= 0)
                {
                    stockCount = value;
                }
                else
                {
                    Console.WriteLine("Invalid stock count. Setting to 0.");
                    stockCount = 0;
                }
            }
        }
    }
    public class MallStore
    {
       public List<Product> products = new List<Product>();
        public void findProducts(string searchName)
        {
            foreach (var product in products)
            {
                if (product.Name.Contains(searchName))
                {
                    Console.WriteLine($"Product found: {product.Name}, Price: {product.Price}, Stock Count: {product.StockCount}");
                }
            }
        }
    }
}
