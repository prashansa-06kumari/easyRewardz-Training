using System;

namespace Practice
{
    class ThisKeywordDemo
    {
        private string name;
        private int age;

        public ThisKeywordDemo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }

        public void Display()
        {
            Console.WriteLine("Display Method");
            this.ShowDetails();
        }
    }
}