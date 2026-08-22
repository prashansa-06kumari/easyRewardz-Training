using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
}

public class TimeTasks
{
    [LogExecutionTime]
    public void FastMethod()
    {
        Thread.Sleep(100);
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        Thread.Sleep(500);
    }
}

public class Problem3
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 3: Execution Time =====");

        TimeTasks tasks = new TimeTasks();

        Type type = typeof(TimeTasks);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            LogExecutionTimeAttribute attribute =
                method.GetCustomAttribute<LogExecutionTimeAttribute>();

            if (attribute != null)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                method.Invoke(tasks, null);

                stopwatch.Stop();

                Console.WriteLine(
                    $"Method: {method.Name}");

                Console.WriteLine(
                    $"Time: {stopwatch.ElapsedMilliseconds} ms");

                Console.WriteLine();
            }
        }
    }
}