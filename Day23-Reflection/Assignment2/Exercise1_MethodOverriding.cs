using System;
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof Woof!");
    }
}
public class Exercise1
{
    public static void Run()
    {
        Console.WriteLine("===== Exercise 1: Method Overriding =====");
        Dog dog = new Dog();
        dog.MakeSound();
    }
}