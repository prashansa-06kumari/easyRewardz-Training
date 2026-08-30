using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Problem08_ReadKeysValues
{
    public static void Run()
    {
        string json = File.ReadAllText("users.json");

        JArray users = JArray.Parse(json);

        foreach (JObject user in users)
        {
            foreach (var property in user.Properties())
            {
                Console.WriteLine(
                    $"Key: {property.Name}, Value: {property.Value}"
                );
            }

            Console.WriteLine();
        }
    }
}