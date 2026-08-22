using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(
        string priority,
        string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

public class TaskManager
{
    [TaskInfo("HIGH", "Prashansa")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }

    public void NormalTask()
    {
        Console.WriteLine("Normal task.");
    }
}

public class Exercise4
{
    public static void Run()
    {
        Console.WriteLine("===== Exercise 4: TaskInfo Attribute =====");

        Type type = typeof(TaskManager);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            TaskInfoAttribute attribute =
                method.GetCustomAttribute<TaskInfoAttribute>();

            if (attribute != null)
            {
                Console.WriteLine("Method: " + method.Name);
                Console.WriteLine("Priority: " + attribute.Priority);
                Console.WriteLine("Assigned To: " + attribute.AssignedTo);
            }
        }
    }
}