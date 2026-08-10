using System;
using System.Collections.Generic;

namespace Assignment
{
    class ListPractice
    {
        public static void Run()
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            Console.WriteLine("Fruits:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Remove("Banana");

            Console.WriteLine("\nAfter Remove:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}