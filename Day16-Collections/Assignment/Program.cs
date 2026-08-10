using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList\n");
            ArrayListPractice.Run();

            Console.WriteLine("\nHashtable\n");
            HashtablePractice.Run();

            Console.WriteLine("\nStack\n");
            StackPractice.Run();

            Console.WriteLine("\nQueue\n");
            QueuePractice.Run();

            Console.WriteLine("\nList\n");
            ListPractice.Run();

            Console.WriteLine("\nDictionary\n");
            DictionaryPractice.Run();

            Console.WriteLine("\nSortedList\n");
            SortedListPractice.Run();

            Console.WriteLine("\nHashSet\n");
            HashSetPractice.Run();

            Console.WriteLine("\nSortedSet\n");
            SortedSetPractice.Run();
        }
    }
}