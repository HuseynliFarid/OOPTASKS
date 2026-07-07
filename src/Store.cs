using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS
{
    internal class Product
    {
        private double price {  get; set; }

        public double _price
        {
            get
            {
                return price;
            }
            set
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

