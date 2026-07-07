using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS
{
    internal class ProductSystem
    {
        private double price {  get; set; } // Private field to store the price

        public double _price // Public property to access the price
        {
            get // Getter method to retrieve the price
            {
                return price;
            }
            set // Setter method to set the price with validation
            {
                if(value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }
    }
} 

