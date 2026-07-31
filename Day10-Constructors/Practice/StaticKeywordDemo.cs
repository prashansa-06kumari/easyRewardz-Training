using System;

namespace Practice
{
    class StaticKeywordDemo
    {
        private string name;
        private static int count;
        // Static Constructor
        static StaticKeywordDemo()
        {
            count = 0;
            Console.WriteLine("Static Constructor Called");
        }
        // Instance Constructor
        public StaticKeywordDemo(string name)
        {
            this.name = name;
            count++;
        }
        public void Display()
        {
            Console.WriteLine("Name : " + name);
        }
        public static void DisplayCount()
        {
            Console.WriteLine("Total Objects Created : " + count);
        }
    }
}