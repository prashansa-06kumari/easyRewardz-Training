using System;
using System.Collections;

namespace Assignment
{
    class StackPractice
    {
        public static void Run()
        {
            Stack numbers = new Stack();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            Console.WriteLine("Top Element : " + numbers.Peek());

            Console.WriteLine("\nPopping Elements:");

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}