Easy Level (4 Tasks)

Book World (Class \& Object): Create a class named Book with properties Title, Author, and PageCount. In the Main method, create 2 different book objects and print their details to the console.



Calculator (Overloading): Create a class named MathOperations. Inside, create a method named Add. Overload this method: one version should add 2 numbers, and the other version should add 3 numbers. Both should return the result.



Network Profile (Encapsulation): Create a class named UserProfile with fields username and password. Restrict direct access to password. If someone tries to set a password shorter than 6 characters, print "Password is too short!" to the console and do not assign it.



Vehicle Sound (Polymorphism): Create a base class named Vehicle with a method Drive() (prints "Vehicle is moving"). Create a derived class named SportsCar that inherits from Vehicle and overrides the Drive() method to print "The car is flying at 200 km/h!".



🟡 Medium Level (4 Tasks)

Company System (Inheritance \& Encapsulation): Create a base class named Employee (with properties FirstName, LastName, and Salary). Create a derived class named Manager that inherits from Employee and adds a Bonus property. Write a method to calculate the manager's total income (Salary + Bonus).



Animal Kingdom (Abstraction \& Inheritance): Create an abstract class named Animal that contains an abstract void MakeSound(); method. Create Dog and Cat classes that inherit from this class, each implementing its own sound. Verify in your code that you cannot instantiate the abstract class directly.



Student List (Loops \& Classes): Create a Student class with properties Name and Grade. In the Main method, create a List<Student> and add 3 students to it. Use a foreach loop to print the names of students whose grade is above 50.



Bank Account (Encapsulation): Create a class named BankAccount. Keep the balance field private. Write Deposit(double amount) and Withdraw(double amount) methods. In the Withdraw method, if there is not enough money in the balance, display a warning message.



🔴 Hard Level (2 Tasks)

Store Management System (Collections + OOP): Create a Product class (Name, Price, StockCount). Create a second class named Store which contains a List<Product>. Inside the Store class, write a method named FindProduct(string name). This method should iterate through the products using a foreach loop and print all details of the matching product. If not found, it should print "Product not found".



Payment System (Polymorphism Mix): Create a base class named Payment with a virtual void ProcessPayment(double amount) method that prints "Cash payment processed: X USD". Create a derived class named CardPayment, override the method, and make it print "Card payment processed: X USD (with 1% fee)". Test both payment types in your Main method.

