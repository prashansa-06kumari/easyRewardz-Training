using System;

namespace Assignment
{
    class Animal
    {
        protected string name;
        protected int age;

        // Initialize animal details
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} barks.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} meows.");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} chirps.");
        }
    }
}