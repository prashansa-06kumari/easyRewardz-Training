using System;
using Newtonsoft.Json;

class Problem01_CreateJsonObject
{
    public static void Run()
    {
        var student = new
        {
            name = "Rahul",
            age = 21,
            subjects = new[]
            {
                "C#",
                "Java",
                "Database"
            }
        };

        string json = JsonConvert.SerializeObject(
            student,
            Formatting.Indented
        );

        Console.WriteLine(json);
    }
}