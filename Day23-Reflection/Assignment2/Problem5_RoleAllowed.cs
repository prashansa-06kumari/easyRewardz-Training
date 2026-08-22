using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

public class AdminOperations
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine(
            "User deleted successfully.");
    }

    [RoleAllowed("USER")]
    public void ViewProfile()
    {
        Console.WriteLine(
            "Profile viewed successfully.");
    }
}

public class Problem5
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 5: Role-Based Access =====");

        AdminOperations operations =
            new AdminOperations();

        string currentRole = "USER";

        InvokeMethod(
            operations,
            "DeleteUser",
            currentRole);

        Console.WriteLine();

        currentRole = "ADMIN";

        InvokeMethod(
            operations,
            "DeleteUser",
            currentRole);
    }

    static void InvokeMethod(
        object obj,
        string methodName,
        string currentRole)
    {
        MethodInfo method =
            obj.GetType().GetMethod(methodName);

        RoleAllowedAttribute attribute =
            method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attribute == null)
        {
            method.Invoke(obj, null);
            return;
        }

        if (attribute.Role == currentRole)
        {
            method.Invoke(obj, null);
        }
        else
        {
            Console.WriteLine(
                "Access Denied!");
        }
    }
}