using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

public class JsonUser
{
    [JsonField(Name = "user_name")]
    public string Username = "Prashansa";

    [JsonField(Name = "user_age")]
    public int Age = 21;

    public string Country = "India";
}

public class Problem6
{
    public static void Run()
    {
        Console.WriteLine(
            "===== Problem 6: Custom JSON Serialization =====");

        JsonUser user = new JsonUser();

        string json = ConvertToJson(user);

        Console.WriteLine(json);
    }

    static string ConvertToJson(object obj)
    {
        Type type = obj.GetType();

        FieldInfo[] fields =
            type.GetFields(
                BindingFlags.Public |
                BindingFlags.Instance
            );

        StringBuilder json =
            new StringBuilder();

        json.AppendLine("{");

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];

            JsonFieldAttribute attribute =
                field.GetCustomAttribute<JsonFieldAttribute>();

            string fieldName;

            if (attribute != null &&
                !string.IsNullOrEmpty(attribute.Name))
            {
                fieldName = attribute.Name;
            }
            else
            {
                fieldName = field.Name;
            }

            object value = field.GetValue(obj);

            json.Append(
                $"  \"{fieldName}\": \"{value}\"");

            if (i < fields.Length - 1)
            {
                json.Append(",");
            }

            json.AppendLine();
        }

        json.Append("}");

        return json.ToString();
    }
}