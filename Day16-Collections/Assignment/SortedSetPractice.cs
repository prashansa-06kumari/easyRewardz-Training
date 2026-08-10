using System;
using System.Collections.Generic;

namespace Assignment
{
    class SortedSetPractice
    {
        public static void Run()
        {
            SortedSet<int> numbers = new SortedSet<int>();

            numbers.Add(30);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(20);

            Console.WriteLine("Numbers:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Remove(20);

            Console.WriteLine("\nAfter Remove:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}