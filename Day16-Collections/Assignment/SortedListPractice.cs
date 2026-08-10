using System;
using System.Collections.Generic;

namespace Assignment
{
    class SortedListPractice
    {
        public static void Run()
        {
            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(3, "Aman");
            students.Add(1, "Prince");
            students.Add(2, "Rahul");

            Console.WriteLine("Students:");

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