using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Bank Account System ==========\n");

            BankAccountSystem account = new BankAccountSystem("Aarav Sharma", "SBI2026");

            if (account is BankAccountSystem)
            {
                account.DisplayDetails();
            }

            BankAccountSystem.GetTotalAccounts();

            Console.WriteLine("\n========== Library Management ==========\n");

            LibraryManagement book = new LibraryManagement(
                "The Alchemist",
                "Paulo Coelho",
                "ISBN1001");

            if (book is LibraryManagement)
            {
                book.DisplayDetails();
            }
            LibraryManagement.DisplayLibraryName();

            Console.WriteLine("\n========== Employee Management ==========\n");

            EmployeeManagement employee =
                new EmployeeManagement("Neha Verma", 102, "Software Developer");

            if (employee is EmployeeManagement)
            {
                employee.DisplayDetails();
            }
            EmployeeManagement.DisplayTotalEmployees();

            Console.WriteLine("\n========== Shopping Cart ==========\n");

            ShoppingCart product =
                new ShoppingCart(301, "Smartphone", 28000, 2);

            if (product is ShoppingCart)
            {
                product.DisplayDetails();
            }

            ShoppingCart.UpdateDiscount(15);
            Console.WriteLine("\nAfter Updating Discount:\n");
            product.DisplayDetails();

            Console.WriteLine("\n========== University Student ==========\n");

            UniversityStudent student =
                new UniversityStudent("Riya Gupta", 240215, "A");

            if (student is UniversityStudent)
            {
                student.DisplayDetails();
            }

            UniversityStudent.DisplayTotalStudents();

            Console.WriteLine("\n========== Vehicle Registration ==========\n");
            VehicleRegistration vehicle =
                new VehicleRegistration("Rahul Singh", "Bike", "PB10CD4567");

            if (vehicle is VehicleRegistration)
            {
                vehicle.DisplayDetails();
            }

            VehicleRegistration.UpdateRegistrationFee(6500);

            Console.WriteLine("\nAfter Updating Registration Fee:\n");
            vehicle.DisplayDetails();

            Console.WriteLine("\n========== Hospital Management ==========\n");

            HospitalManagement patient =
                new HospitalManagement(601, "Ananya Patel", 24, "Dengue");

            if (patient is HospitalManagement)
            {
                patient.DisplayDetails();
            }

            HospitalManagement.GetTotalPatients();
        }
    }
}