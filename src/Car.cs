using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    internal class Car
    {
        public virtual void CaRide()
        {
            Console.WriteLine("The car is riding.");
        }
    }
    internal class SportsCar : Car
    {
        public override void CaRide()
        {
            Console.WriteLine("The sports car is flying 200 mph.");
        }
    }
}
