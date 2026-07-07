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
            Profile profil = new Profile("JohnDoe", "secur123");
            // profil.userName = "JohnDoe";                 //after constructor, we can set the username directly
            // profil.Password = "secur123"; // Set the password using the property
            Console.WriteLine(profil.Password);

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

            //Animals abstarct class and inhertance
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.MakeSound(); // Calls the overridden method in Dog class
            cat.MakeSound(); // Calls the overridden method in Cat class
            // Animals animal = new Animals(); // Cannot create an instance of the abstract class 'Animals' because it is abstract and cannot be instantiated

            Console.WriteLine("______________________");

            //Student class with encapsulation
            //List<Student> students = new List<Student>();
            //students.Add(new Student { Name = "Alice", Point = 85 });
            //students.Add(new Student { Name = "Bob", Point = 20 });
            //students.Add(new Student { Name = "Charlie", Point = 55 });
            //for (int i = 0; i < students.Count; i++)
            //{
            //    if(students[i].Point < 50)
            //    {
            //        Console.WriteLine($"Name: {students[i].Name}, Point: {students[i].Point} failed !");
            //    }
            //    else {
            //        Console.WriteLine($"Name: {students[i].Name}, Point: {students[i].Point} passed ");
            //    }   
            //}

            //BankAccount class with encapsulation
            BankAccount account = new BankAccount();
            account.InputBalance(1000); // Set the initial balance
            account.WithdrawBalance(1200); // Error : Insufficient balance
            Console.WriteLine($"Current Balance: {account.GetBalance()}"); // Output: Current Balance: 1000

            //
        }
    }
 }
    