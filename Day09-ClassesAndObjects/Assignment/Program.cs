using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Prince Sharma", 101, 50000);
            emp.DisplayDetails();
            Circle circle = new Circle(7);
            circle.DisplayDetails();
            Book book = new Book("The Alchemist", "Paulo Coelho", 499);
            book.DisplayDetails();
        }
    }
}