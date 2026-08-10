using System;
using System.Collections;

namespace Assignment
{
    class HashtablePractice
    {
        public static void Run()
        {
            Hashtable students = new Hashtable();

            students.Add(1, "Prince");
            students.Add(2, "Rahul");
            students.Add(3, "Aman");

            Console.WriteLine("Student with ID 1: " + students[1]);

            Console.WriteLine("\nAll Students:");

            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine(student.Key + " : " + student.Value);
            }

            students.Remove(2);

            Console.WriteLine("\nAfter Remove:");

            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine(student.Key + " : " + student.Value);
            }
        }
    }
}