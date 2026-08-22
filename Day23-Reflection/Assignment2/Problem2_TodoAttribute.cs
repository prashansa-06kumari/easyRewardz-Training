using System;
using System.Reflection;

[AttributeUsage(
    AttributeTargets.Method,
    AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(
        string task,
        string assignedTo,
        string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

public class ProjectTasks
{
    [Todo(
        "Implement login",
        "Prashansa",
        "HIGH")]
    public void Login()
    {
    }

    [Todo(
        "Create dashboard",
        "Rahul")]
    public void Dashboard()
    {
    }

    [Todo(
        "Add notifications",
        "Aman",
        "LOW")]
    public void Notifications()
    {
    }
}

public class Problem2
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 2: Todo Attribute =====");

        Type type = typeof(ProjectTasks);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            TodoAttribute[] todos =
                method.GetCustomAttributes<TodoAttribute>();

            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine(
                    $"Method: {method.Name}");

                Console.WriteLine(
                    $"Task: {todo.Task}");

                Console.WriteLine(
                    $"Assigned To: {todo.AssignedTo}");

                Console.WriteLine(
                    $"Priority: {todo.Priority}");

                Console.WriteLine();
            }
        }
    }
}