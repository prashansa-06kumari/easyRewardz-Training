using System;

namespace Assignment
{
    class Person
    {
        private string name;
        private int age;
        // Parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // Copy constructor
        public Person(Person person)
        {
            name = person.name;
            age = person.age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
        }
    }
}