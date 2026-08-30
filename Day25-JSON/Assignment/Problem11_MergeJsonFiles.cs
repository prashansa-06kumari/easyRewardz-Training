using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Problem11_MergeJsonFiles
{
    public static void Run()
    {
        string json1 =
            File.ReadAllText("students1.json");

        string json2 =
            File.ReadAllText("students2.json");

        JArray students1 = JArray.Parse(json1);
        JArray students2 = JArray.Parse(json2);

        JArray result = new JArray();

        foreach (JObject student1 in students1)
        {
            int id = (int)student1["id"];

            JObject merged =
                new JObject(student1);

            foreach (JObject student2 in students2)
            {
                if ((int)student2["id"] == id)
                {
                    merged.Merge(student2);
                    break;
                }
            }

            result.Add(merged);
        }

        File.WriteAllText(
            "merged_students.json",
            result.ToString()
        );

        Console.WriteLine(
            "JSON files merged successfully."
        );
    }
}