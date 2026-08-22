using System;
using System.Collections;

public class Exercise3
{
    public static void Run()
    {
        Console.WriteLine("===== Exercise 3: Pragma Warning =====");

#pragma warning disable CS0618

        ArrayList numbers = new ArrayList();

#pragma warning restore CS0618

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        foreach (object number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}