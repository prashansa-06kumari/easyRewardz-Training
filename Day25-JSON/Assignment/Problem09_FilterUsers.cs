using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Problem09_FilterUsers
{
    public static void Run()
    {
        string json = File.ReadAllText("users.json");

        JArray users = JArray.Parse(json);

        Console.WriteLine("Users older than 25:");

        foreach (JObject user in users)
        {
            int age = (int)user["age"];

            if (age > 25)
            {
                Console.WriteLine(
                    $"Name: {user["name"]}"
                );

                Console.WriteLine(
                    $"Age: {user["age"]}"
                );

                Console.WriteLine();
            }
        }
    }
}