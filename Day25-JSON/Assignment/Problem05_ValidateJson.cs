using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Problem05_ValidateJson
{
    public static void Run()
    {
        string json = @"{
            ""name"": ""Rahul"",
            ""age"": 25,
            ""email"": ""rahul@gmail.com""
        }";

        string schemaJson = @"{
            ""type"": ""object"",
            ""properties"": {
                ""name"": {
                    ""type"": ""string""
                },
                ""age"": {
                    ""type"": ""integer""
                },
                ""email"": {
                    ""type"": ""string""
                }
            },
            ""required"": [
                ""name"",
                ""age"",
                ""email""
            ]
        }";

        JObject jsonObject = JObject.Parse(json);

        JSchema schema = JSchema.Parse(schemaJson);

        bool valid = jsonObject.IsValid(schema);

        Console.WriteLine(
            valid
                ? "JSON is valid."
                : "JSON is invalid."
        );
    }
}