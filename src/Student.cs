using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    public class Student
    {
        public string Name;
        private byte _point;
        
        public byte Point
        {
            get { return _point; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Point must be between 0 and 100.");
                }
                else _point = value;
            }
        }

    }
}
