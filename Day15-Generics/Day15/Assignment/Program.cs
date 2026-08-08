using System;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Warehouse

            Storage<Electronics> elec = new Storage<Electronics>();

            elec.Add(new Electronics(1,"Laptop"));
            elec.Add(new Electronics(2, "Phone"));

            Console.WriteLine("Warehouse:");
            elec.ShowAll();


            // 2. Marketplace

            Book book=new Book(1,"CSharp Book", 500, "John");

            ProductHelper.ApplyDiscount(book,10);

            Console.WriteLine("\nMarketplace:");
            book.Show();


            // 3. University

            Course<ExamCourse> exam=new Course<ExamCourse>();

            exam.Add(new ExamCourse("CSharp"));
            exam.Add(new ExamCourse("Database"));

            Console.WriteLine("\nUniversity:");
            exam.Show();


            // 4. Meal Plan

            Meal<VegetarianMeal> veg=
                new Meal<VegetarianMeal>(new VegetarianMeal());

            Console.WriteLine("\nMeal Plan:");
            veg.Generate();


            // 5. Resume Screening

            Resume<SoftwareEngineer> resume =
                new Resume<SoftwareEngineer>();

            resume.Add(new SoftwareEngineer("Rahul"));
            resume.Add(new SoftwareEngineer("Aman"));
            Console.WriteLine("\nResume Screening:");
            resume.ScreenAll();
        }
    }
}