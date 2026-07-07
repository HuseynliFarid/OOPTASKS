using System;
namespace OOPTASKS
{
   
    class MainOOPTASKS
    {
        static void Main(string[] args)
        {
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
        }
    }
}