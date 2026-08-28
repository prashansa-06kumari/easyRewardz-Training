using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class JsonStudent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class Problem14_JsonCsv
{
    public static void Run()
    {
        string jsonFile="students.json";
        string csvFile="students_from_json.csv";
        string outputJson = "students_from_csv.json";
        // JSON to CSV
        string json = File.ReadAllText(jsonFile);
        List<JsonStudent> students=JsonSerializer.Deserialize<List<JsonStudent>>(json);
        List<string> csvLines = new List<string>();
        csvLines.Add("Id,Name,Age,Marks");
        foreach (JsonStudent student in students)
        {
            csvLines.Add( $"{student.Id},{student.Name},{student.Age},{student.Marks}");
        }
        File.WriteAllLines(csvFile, csvLines);
        Console.WriteLine("JSON converted to CSV.");
        // CSV to JSON
        string[] lines = File.ReadAllLines(csvFile);
        List<JsonStudent> studentsFromCsv = new List<JsonStudent>();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            JsonStudent student = new JsonStudent
            {
                Id = int.Parse(data[0]),
                Name=data[1],
                Age=int.Parse(data[2]),
                Marks = double.Parse(data[3])
            };
            studentsFromCsv.Add(student);
        }
        string convertedJson =
            JsonSerializer.Serialize(
                studentsFromCsv,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );
        File.WriteAllText(outputJson, convertedJson);
        Console.WriteLine("CSV converted back to JSON.");
    }
}