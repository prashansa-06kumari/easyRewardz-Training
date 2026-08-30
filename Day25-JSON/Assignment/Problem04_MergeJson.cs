using System;
using Newtonsoft.Json.Linq;

class Problem04_MergeJson
{
    public static void Run()
    {
        JObject object1 = JObject.Parse(
            @"{
                ""name"": ""Rahul"",
                ""age"": 25
            }"
        );

        JObject object2 = JObject.Parse(
            @"{
                ""email"": ""rahul@gmail.com"",
                ""city"": ""Delhi""
            }"
        );

        object1.Merge(object2);

        Console.WriteLine(
            object1.ToString()
        );
    }
}