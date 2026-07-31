using System;

namespace Assignment
{
    class Course
    {
        private string courseName;
        private int duration;
        private double fee;
        private static string instituteName = "Chitkara University";
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course Name : {courseName}");
            Console.WriteLine($"Duration    : {duration} Months");
            Console.WriteLine($"Fee         : ₹{fee}");
            Console.WriteLine($"Institute   : {instituteName}");
        }
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }
    }
}