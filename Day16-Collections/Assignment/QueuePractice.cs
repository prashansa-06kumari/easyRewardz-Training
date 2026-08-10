using System;
using System.Collections;

namespace Assignment
{
    class QueuePractice
    {
        public static void Run()
        {
            Queue customers = new Queue();

            customers.Enqueue("Prince");
            customers.Enqueue("Rahul");
            customers.Enqueue("Aman");

            Console.WriteLine("First Customer : " + customers.Peek());

            Console.WriteLine("\nServing Customers:");

            while (customers.Count > 0)
            {
                Console.WriteLine(customers.Dequeue());
            }
        }
    }
}