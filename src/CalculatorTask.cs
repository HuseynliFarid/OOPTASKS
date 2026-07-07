using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS
{
    public class Calculator
    {
       public int number1;
       public int number2;
       public int number3;
        public  int CalculateSum(int number1, int number2) 
        {
            return number1 + number2;
        }
        public int CalculateSum(int number1, int number2, int number3) // Method overloading: same method name but different parameters
        {
            return number1 + number2 + number3;
        }
    }
}
