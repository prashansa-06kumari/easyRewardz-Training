using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Problem07_FilterJson
{
    public static void Run()
    {
        string json = File.ReadAllText("users.json");

        JArray users = JArray.Parse(json);

        foreach (JObject user in users)
        {
            int age = (int)user["age"];

            if (age > 25)
            {
                Console.WriteLine(
                    $"{user["name"]} - {age}"
                );
            }
        }
    }
}