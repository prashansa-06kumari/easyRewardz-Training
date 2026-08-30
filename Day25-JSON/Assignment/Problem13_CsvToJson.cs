using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class CsvStudent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Problem13_CsvToJson
{
    public static void Run()
    {
        string[] lines =
            File.ReadAllLines("students.csv");

        List<CsvStudent> students =
            new List<CsvStudent>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            CsvStudent student = new CsvStudent
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            };

            students.Add(student);
        }

        string json =
            JsonConvert.SerializeObject(
                students,
                Formatting.Indented
            );

        File.WriteAllText(
            "students.json",
            json
        );

        Console.WriteLine(
            "CSV converted to JSON successfully."
        );
    }
}