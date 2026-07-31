using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorsDemo();
            InstanceAndClassVariablesDemo();
            AccessModifiersDemo();
        }
        static void ConstructorsDemo()
        {
            Console.WriteLine("========== Constructors ==========\n");

            Book book = new Book("The Alchemist", "Paulo Coelho");
            book.DisplayDetails();

            Console.WriteLine();

            Circle circle = new Circle(7);
            circle.DisplayDetails();

            Console.WriteLine();

            Person originalPerson = new Person("Prince", 21);
            Person copiedPerson = new Person(originalPerson);
            copiedPerson.DisplayDetails();
            Console.WriteLine();

            HotelBooking hotel = new HotelBooking("Prince", "Deluxe", 3);
            hotel.DisplayDetails();

            Console.WriteLine();

            LibraryBook library = new LibraryBook("Atomic Habits", "James Clear", 599);
            library.DisplayDetails();
            library.BorrowBook();

            Console.WriteLine();
            CarRental car = new CarRental("Prince", "Honda City", 5);
            car.DisplayDetails();

            Console.WriteLine();
        }

        static void InstanceAndClassVariablesDemo()
        {
            Console.WriteLine("========== Instance vs Class Variables ==========\n");
            Product laptop = new Product("Laptop", 75000);
            Product mouse = new Product("Mouse", 1200);

            laptop.DisplayProductDetails();

            Console.WriteLine();

            mouse.DisplayProductDetails();

            Console.WriteLine();

            Product.DisplayTotalProducts();

            Console.WriteLine();

            Course csharp = new Course("C#", 30, 5000);
            csharp.DisplayCourseDetails();

            Console.WriteLine();

            Course.UpdateInstituteName("EasyRewardsz");
            csharp.DisplayCourseDetails();

            Console.WriteLine();

            Vehicle vehicle = new Vehicle("Prince", "Car");
            vehicle.DisplayVehicleDetails();

            Console.WriteLine();

            Vehicle.UpdateRegistrationFee(6500);
            vehicle.DisplayVehicleDetails();

            Console.WriteLine();
        }

        static void AccessModifiersDemo()
        {
            Console.WriteLine("========== Access Modifiers ==========\n");

            PostgraduateStudent student = new PostgraduateStudent(101, "Prince", 9.2);
            student.DisplayDetails();

            Console.WriteLine();

            EBook ebook = new EBook("978-12345", "C# Programming", "John Smith");
            ebook.DisplayDetails();

            Console.WriteLine();

            SavingsAccount account = new SavingsAccount("ACC1001", "Prince", 50000);
            account.DisplayDetails();

            Console.WriteLine();

            Manager manager = new Manager(501, "IT", 85000);
            manager.DisplayDetails();
        }
    }
}