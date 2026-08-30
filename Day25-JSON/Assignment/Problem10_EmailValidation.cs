using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Problem10_EmailValidation
{
    public static void Run()
    {
        string json = @"{
            ""name"": ""Rahul"",
            ""email"": ""rahul@gmail.com""
        }";

        string schemaJson = @"{
            ""type"": ""object"",
            ""properties"": {
                ""name"": {
                    ""type"": ""string""
                },
                ""email"": {
                    ""type"": ""string"",
                    ""format"": ""email""
                }
            },
            ""required"": [
                ""name"",
                ""email""
            ]
        }";

        JObject data = JObject.Parse(json);

        JSchema schema = JSchema.Parse(schemaJson);

        bool valid = data.IsValid(schema);

        Console.WriteLine(
            valid
                ? "Email is valid."
                : "Email is invalid."
        );
    }
}