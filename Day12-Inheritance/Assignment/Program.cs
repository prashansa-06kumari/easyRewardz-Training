using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Hierarchy\n");

            Animal[] animals =
            {
                new Dog("Tommy", 3),
                new Cat("Kitty", 2),
                new Bird("Tweety", 1)
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine("\nEmployee Management\n");

            Employee[] employees =
            {
                new Manager("Prince", 101, 80000, 8),
                new Developer("Rahul", 102, 60000, "C#"),
                new Intern("Aman", 103, 20000, "6 Months")
            };

            foreach (Employee employee in employees)
            {
                employee.DisplayDetails();
                Console.WriteLine();
            }

            Console.WriteLine("Vehicle Transport \n");

            Vehicle[] vehicles =
            {
                new Car(220, "Petrol", 5),
                new Truck(120, "Diesel", 5000),
                new Motorcycle(160, "Petrol", false)
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}