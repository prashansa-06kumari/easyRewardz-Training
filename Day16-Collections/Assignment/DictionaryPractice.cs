using System;
using System.Collections.Generic;

namespace Assignment
{
    class DictionaryPractice
    {
        public static void Run()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Prince");
            students.Add(2, "Rahul");
            students.Add(3, "Aman");

            Console.WriteLine("Student with ID 1: " + students[1]);

            Console.WriteLine("\nAll Students:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " : " + student.Value);
            }

            students.Remove(2);

            Console.WriteLine("\nAfter Remove:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " : " + student.Value);
            }
        }
    }
}