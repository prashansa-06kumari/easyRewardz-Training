using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(
    AttributeTargets.Method,
    AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

public class BugTracker
{
    [BugReport("Button does not respond.")]
    [BugReport("UI alignment issue.")]
    public void Login()
    {
        Console.WriteLine("Login method executed.");
    }
}

public class Exercise5
{
    public static void Run()
    {
        Console.WriteLine("===== Exercise 5: Repeatable Attribute =====");

        MethodInfo method =
            typeof(BugTracker).GetMethod("Login")!;

        BugReportAttribute[] reports =
            method.GetCustomAttributes<BugReportAttribute>().ToArray();

        Console.WriteLine("Method: " + method.Name);

        foreach (BugReportAttribute report in reports)
        {
            Console.WriteLine(
                "Bug: " + report.Description);
        }
    }
}