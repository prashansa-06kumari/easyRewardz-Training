using System;

namespace Practice
{
    class Animal
    {
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    class IsOperatorDemo
    {
        public void CheckType()
        {
            Animal animal = new Dog();

            if (animal is Dog)
            {
                Console.WriteLine("animal is a Dog");

                Dog dog = (Dog)animal;
                dog.Bark();
            }
            if (animal is Animal)
            {
                Console.WriteLine("animal is also an Animal");
            }
        }
    }
}