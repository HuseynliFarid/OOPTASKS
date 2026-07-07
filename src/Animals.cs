using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    // Abstract class representing animals
    public abstract class Animals
    {
        public abstract void MakeSound();
    }
    public class Dog : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
