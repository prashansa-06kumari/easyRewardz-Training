using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

public class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        FieldInfo field =
            typeof(User).GetField("Username");

        MaxLengthAttribute attribute =
            field.GetCustomAttribute<MaxLengthAttribute>();

        if (attribute != null &&
            username.Length > attribute.Value)
        {
            throw new ArgumentException(
                $"Username cannot exceed {attribute.Value} characters.");
        }

        Username = username;
    }
}

public class Problem4
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 4: MaxLength Attribute =====");

        try
        {
            User user = new User("Prashansa");

            Console.WriteLine(
                "Username: " + user.Username);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(
                exception.Message);
        }

        try
        {
            User user = new User(
                "ThisUsernameIsTooLong");

            Console.WriteLine(
                "Username: " + user.Username);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(
                exception.Message);
        }
    }
}