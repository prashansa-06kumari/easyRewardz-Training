using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance \n");

            Author author = new Author(
                "Atomic Habits",
                2018,
                "James Clear",
                "Self-help Author");

            author.DisplayInfo();

            Console.WriteLine();

            Thermostat thermostat = new Thermostat(101, "Active", 24);
            thermostat.DisplayStatus();

            Console.WriteLine("\nMultilevel Inheritance\n");

            DeliveredOrder order = new DeliveredOrder(
                1001,
                "01-Aug-2026",
                "TRK12345",
                "03-Aug-2026");

            order.GetOrderStatus();

            Console.WriteLine();

            PaidOnlineCourse course = new PaidOnlineCourse(
                "C# Programming",
                "8 Weeks",
                "Udemy",
                true,
                2999,
                20);

            course.DisplayCourse();

            Console.WriteLine("\nHierarchical Inheritance \n");

            SavingsAccount savings = new SavingsAccount("SB1001", 50000, 6.5);
            savings.DisplayAccountType();

            Console.WriteLine();

            Teacher teacher = new Teacher("Prince", 22, "C#");
            teacher.DisplayRole();

            Console.WriteLine("\nHybrid Inheritance\n");

            Chef chef = new Chef("Ramesh", 1);
            chef.PerformDuties();

            Waiter waiter = new Waiter("Suresh", 2);
            waiter.PerformDuties();

            ElectricVehicle ev = new ElectricVehicle(180, "Tesla Model 3");
            ev.Charge();

            PetrolVehicle pv = new PetrolVehicle(220, "Honda City");
            pv.Refuel();
        }
    }
}