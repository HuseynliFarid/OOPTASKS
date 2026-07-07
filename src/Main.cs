using OOPTASKS.src;
using System;
namespace OOPTASKS
{
   
    class MainOOPTASKS
    {
        static void Main(string[] args)
        {
            //    Easy Tasks 5


            // Create an instance of the Book class
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

            //Store 
            Product product = new Product();
            product._price = 25.99; // Set the price using the property
            product._price = -10; // Attempt to set a negative price (will be set to 0)
            Console.WriteLine(product._price);

            //Calculate Overloading rules
            Calculator calculator = new Calculator();
            calculator.CalculateSum(5, 10); // Calls the method with two parameters
            calculator.CalculateSum(5, 10, 15); // Calls the method with three parameters

            //Profile
            Profile profil = new Profile();
            profil.userName = "JohnDoe";
            profil._password = "secur123"; // Set the password using the property
            Console.WriteLine(profil._password);

            //Inhertance and Polymorphism overriding
            Car car = new Car();
            car.CaRide(); // Calls the method in Car class
            SportsCar sportsCar = new SportsCar();
            sportsCar.CaRide(); // Calls the overridden method in SportsCar class



            //   Normal Tasks  4


            //Company Inheritance & Polymorphism
            Employee employee = new Employee("John", "Doe", 30, -500);// returns 0 because salary is negative
            Manager manager = new Manager("Jane", "Smith", 35, 700, 100); 
            Console.WriteLine(manager.CalculateManagerSalary());// returns 800 because salary is 700 and bonus is 100
            Console.WriteLine(employee._salary);

        }
    }
}