using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Problem03_ReadJsonFields
{
    public static void Run()
    {
        string json = File.ReadAllText("users.json");

        JArray users = JArray.Parse(json);

        foreach (JObject user in users)
        {
            Console.WriteLine($"Name: {user["name"]}");
            Console.WriteLine($"Email: {user["email"]}");
            Console.WriteLine();
        }
    }
}