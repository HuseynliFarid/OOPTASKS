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

        }
    }
}