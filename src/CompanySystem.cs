using System;
using System.Transactions;
namespace OOPTASKS
{
    public class Employee
    {
      public  string name;
      public  string lastName;
      public  byte age;
      private double salary;

        public double _salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                    Console.WriteLine("Invalid salary. Setting to 0.");
                }
                else
                {
                    salary = value;
                     Console.WriteLine($"Salary set to: {salary}");
                }
            }
        }
        public Employee(string _name, string _lastName, byte _age, double _salary)
        {
          name = _name;
          lastName = _lastName;
          age = _age;
          this._salary = _salary;
        }
    }
    internal class Manager : Employee
    {
        private double bonus;
        public double _bonus
        {
            get { return bonus; }
            set
            {
                if (value < 0)
                {
                    bonus = 0;
                    Console.WriteLine("Invalid bonus. Setting to 0.");
                }
                else
                {
                    bonus = value;
                    Console.WriteLine($"Bonus set to: {bonus}");
                }
            }
        }
        public Manager(string name, string lastName, byte age, double salary, double _bonus) : base(name, lastName, age, salary) // Call the base class constructor
        {
           this._bonus = _bonus;    
        }
        public double CalculateManagerSalary()
        {
            return _salary + _bonus;
        }
    }
}   