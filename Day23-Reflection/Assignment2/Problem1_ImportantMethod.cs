using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(
        string level = "HIGH")
    {
        Level = level;
    }
}

public class ImportantTasks
{
    [ImportantMethod]
    public void CriticalTask()
    {
        Console.WriteLine("Critical task executed.");
    }

    [ImportantMethod("MEDIUM")]
    public void NormalTask()
    {
        Console.WriteLine("Normal important task executed.");
    }

    public void RegularTask()
    {
        Console.WriteLine("Regular task.");
    }
}

public class Problem1
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 1: ImportantMethod =====");

        Type type = typeof(ImportantTasks);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            ImportantMethodAttribute attribute =
                method.GetCustomAttribute<ImportantMethodAttribute>();

            if (attribute != null)
            {
                Console.WriteLine(
                    $"Method: {method.Name}");

                Console.WriteLine(
                    $"Level: {attribute.Level}");
            }
        }
    }
}