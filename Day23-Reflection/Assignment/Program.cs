using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
public class Person
{
    private int age = 20;

    public string Name = "Prashansa";
}
public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}
[Author("Prashansa")]
public class Book
{
    public string Title = "C# Reflection";
}
public class Configuration
{
    private static string API_KEY = "OLD_API_KEY";
}
public interface IGreeting
{
    void SayHello();
}
public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello from Greeting class!");
    }
}
[AttributeUsage(AttributeTargets.Property)]
public class InjectAttribute : Attribute
{
}
public interface IService
{
    void Execute();
}
public class MyService : IService
{
    public void Execute()
    {
        Console.WriteLine("Service executed successfully.");
    }
}
public class Client
{
    [Inject]
    public IService Service { get; set; }
    public void Run()
    {
        Service.Execute();
    }
}
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("       DAY 23 - REFLECTION ASSIGNMENTS");
            Console.WriteLine("==============================================");

            Console.WriteLine("1. Get Class Information");
            Console.WriteLine("2. Access Private Field");
            Console.WriteLine("3. Invoke Private Method");
            Console.WriteLine("4. Dynamically Create Object");
            Console.WriteLine("5. Dynamic Method Invocation");
            Console.WriteLine("6. Retrieve Attribute");
            Console.WriteLine("7. Modify Static Field");
            Console.WriteLine("8. Custom Object Mapper");
            Console.WriteLine("9. Generate JSON Representation");
            Console.WriteLine("10. Custom Logging Proxy");
            Console.WriteLine("11. Dependency Injection");
            Console.WriteLine("12. Method Execution Timing");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    GetClassInformation();
                    break;

                case "2":
                    AccessPrivateField();
                    break;

                case "3":
                    InvokePrivateMethod();
                    break;

                case "4":
                    DynamicallyCreateObject();
                    break;

                case "5":
                    DynamicMethodInvocation();
                    break;

                case "6":
                    RetrieveAttribute();
                    break;

                case "7":
                    ModifyStaticField();
                    break;

                case "8":
                    CustomObjectMapper();
                    break;

                case "9":
                    GenerateJsonRepresentation();
                    break;

                case "10":
                    CustomLoggingProxy();
                    break;

                case "11":
                    DependencyInjection();
                    break;

                case "12":
                    MethodExecutionTiming();
                    break;

                case "0":
                    Console.WriteLine("Program ended.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
    static void GetClassInformation()
    {
        Console.WriteLine("===== 1. Get Class Information =====");
        Type type = typeof(Student);
        Console.WriteLine($"Class Name: {type.Name}");
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine(field.Name);
        }
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor);
        }
    }
    static void AccessPrivateField()
    {
        Console.WriteLine("===== 2. Access Private Field =====");
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo field = type.GetField(
            "age",
            BindingFlags.NonPublic |
            BindingFlags.Instance
        );
        Console.WriteLine("Original age: " + field.GetValue(person));
        field.SetValue(person, 25);
        Console.WriteLine("Modified age: " + field.GetValue(person));
    }
    static void InvokePrivateMethod()
    {
        Console.WriteLine("===== 3. Invoke Private Method =====");
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);
        MethodInfo method = type.GetMethod(
            "Multiply",
            BindingFlags.NonPublic |
            BindingFlags.Instance
        );
        object result = method.Invoke(
            calculator,
            new object[] { 10, 5 }
        );
        Console.WriteLine("Result: " + result);
    }

    static void DynamicallyCreateObject()
    {
        Console.WriteLine("===== 4. Dynamically Create Object =====");
        Type type = typeof(Student);
        object studentObject = Activator.CreateInstance(type);
        Student student = (Student)studentObject;
        student.Name = "Prashansa";
        student.Age = 21;
        student.Display();
    }
    static void DynamicMethodInvocation()
    {
        Console.WriteLine("===== 5. Dynamic Method Invocation =====");
        MathOperations math = new MathOperations();
        Console.Write("Enter method (Add/Subtract/Multiply): ");
        string methodName = Console.ReadLine();
        Type type = typeof(MathOperations);
        MethodInfo method = type.GetMethod(
            methodName,
            BindingFlags.Public |
            BindingFlags.Instance
        );
        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }
        object result = method.Invoke(
            math,
            new object[] { 20, 5 }
        );

        Console.WriteLine("Result: " + result);
    }

    static void RetrieveAttribute()
    {
        Console.WriteLine("===== 6. Retrieve Attribute =====");
        Type type = typeof(Book);
        AuthorAttribute attribute =
            type.GetCustomAttribute<AuthorAttribute>();

        if (attribute != null)
        {
            Console.WriteLine("Author: " + attribute.Name);
        }
        else
        {
            Console.WriteLine("Author attribute not found.");
        }
    }
    static void ModifyStaticField()
    {
        Console.WriteLine("===== 7. Modify Static Field =====");

        Type type = typeof(Configuration);

        FieldInfo field = type.GetField(
            "API_KEY",
            BindingFlags.NonPublic |
            BindingFlags.Static
        );
        Console.WriteLine(
            "Original API Key: " +
            field.GetValue(null)
        );
        field.SetValue(null, "NEW_API_KEY_123");
        Console.WriteLine(
            "Modified API Key: " +
            field.GetValue(null)
        );
    }
    static void CustomObjectMapper()
    {
        Console.WriteLine("===== 8. Custom Object Mapper =====");
        Dictionary<string, object> properties =
            new Dictionary<string, object>
            {
                { "Name", "Rahul" },
                { "Age", 22 }
            };

        Student student =
            ToObject<Student>(properties);

        student.Display();
    }
    static T ToObject<T>(
        Dictionary<string, object> properties
    ) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);
        foreach (var property in properties)
        {
            PropertyInfo propertyInfo =type.GetProperty(property.Key);
            if (propertyInfo != null &&
                propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(
                    obj,
                    property.Value
                );
            }
        }
        return obj;
    }
    static void GenerateJsonRepresentation()
    {
        Console.WriteLine("===== 9. Generate JSON Representation =====");
        Student student = new Student
        {
            Name = "Prashansa",
            Age = 21
        };
        Type type = student.GetType();
        Console.WriteLine("{");
        PropertyInfo[] properties =type.GetProperties();

        for (int i = 0; i < properties.Length; i++)
        {
            PropertyInfo property = properties[i];
            object value =property.GetValue(student);
            Console.Write(
                $"  \"{property.Name}\": \"{value}\""
            );
            if (i < properties.Length - 1)
                Console.Write(",");

            Console.WriteLine();
        }
        Console.WriteLine("}");
    }
    static void CustomLoggingProxy()
    {
        Console.WriteLine("===== 10. Custom Logging Proxy =====");
        IGreeting greeting = new Greeting();
        Type interfaceType =
            typeof(IGreeting);

        MethodInfo method =
            interfaceType.GetMethod("SayHello");
        Console.WriteLine(
            $"LOG: Calling method {method.Name}"
        );
        method.Invoke(
            greeting,
            null
        );
    }
    static void DependencyInjection()
    {
        Console.WriteLine("===== 11. Dependency Injection =====");
        Client client = new Client();
        Type clientType =
            typeof(Client);

        PropertyInfo[] properties =
            clientType.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            bool hasInject =
                property.GetCustomAttribute<InjectAttribute>()
                != null;

            if (hasInject)
            {
                Type dependencyType =property.PropertyType;
                object dependency =
                    Activator.CreateInstance(
                        typeof(MyService)
                    );
                property.SetValue(
                    client,
                    dependency
                );
            }
        }
        client.Run();
    }
    static void MethodExecutionTiming()
    {
        Console.WriteLine("===== 12. Method Execution Timing =====");
        MathOperations math =new MathOperations();
        Type type =typeof(MathOperations);
        MethodInfo method =
            type.GetMethod("Multiply");
        Stopwatch stopwatch =
            new Stopwatch();

        stopwatch.Start();
        object result =
            method.Invoke(
                math,
                new object[] { 10000, 5000 }
            );
        stopwatch.Stop();
        Console.WriteLine(
            "Result: " + result
        );
        Console.WriteLine(
            "Execution Time: " +
            stopwatch.ElapsedTicks +
            " ticks"
        );
        Console.WriteLine(
            "Execution Time: " +
            stopwatch.Elapsed.TotalMilliseconds +
            " ms"
        );
    }
}