using System;
using System.Collections;

namespace Assignment
{
    class ArrayListPractice
    {
        public static void Run()
        {
            ArrayList fruits = new ArrayList();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            Console.WriteLine("Fruits:");

            foreach (object fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Remove("Banana");

            Console.WriteLine("\nAfter Remove:");

            foreach (object fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}