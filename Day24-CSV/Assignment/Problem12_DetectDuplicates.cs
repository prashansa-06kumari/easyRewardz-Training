using System;
using System.Collections.Generic;
using System.IO;

class Problem12_DetectDuplicates
{
    public static void Run()
    {
        string filePath = "students.csv";
        string[] lines = File.ReadAllLines(filePath);
        HashSet<string> ids = new HashSet<string>();
        Console.WriteLine("Duplicate Records:");
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            string id = data[0];
            if (!ids.Add(id))
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}