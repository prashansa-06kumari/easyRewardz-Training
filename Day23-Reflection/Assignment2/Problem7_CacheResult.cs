using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
}

public class ExpensiveOperations
{
    [CacheResult]
    public int Calculate(int number)
    {
        Console.WriteLine(
            "Performing expensive calculation...");

        int result = 0;

        for (int i = 0; i < 100000000; i++)
        {
            result += number;
        }

        return result;
    }
}

public class Problem7
{
    private static Dictionary<string, object> cache =
        new Dictionary<string, object>();

    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 7: CacheResult =====");

        ExpensiveOperations operations =
            new ExpensiveOperations();

        int firstResult =
            InvokeWithCache(
                operations,
                "Calculate",
                5);

        Console.WriteLine(
            "First Result: " + firstResult);

        Console.WriteLine();

        int secondResult =
            InvokeWithCache(
                operations,
                "Calculate",
                5);

        Console.WriteLine(
            "Second Result: " + secondResult);
    }

    static int InvokeWithCache(
        object obj,
        string methodName,
        int input)
    {
        MethodInfo method =
            obj.GetType().GetMethod(methodName);

        CacheResultAttribute attribute =
            method.GetCustomAttribute<CacheResultAttribute>();

        string key =
            methodName + "_" + input;

        if (attribute != null &&
            cache.ContainsKey(key))
        {
            Console.WriteLine(
                "Returning result from cache...");

            return (int)cache[key];
        }

        object result =
            method.Invoke(
                obj,
                new object[] { input });

        if (attribute != null)
        {
            cache[key] = result;
        }

        return (int)result;
    }
}