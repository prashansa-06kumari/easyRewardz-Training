using System;
using System.Collections.Generic;
using System.IO;

class Problem10_MergeCsv
{
    public static void Run()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";
        string[] students1=File.ReadAllLines(file1);
        string[] students2=File.ReadAllLines(file2);

        Dictionary<string, string[]> marksData =new Dictionary<string, string[]>();
        for (int i=1;i<students2.Length;i++)
        {
            string[] data=students2[i].Split(',');
            marksData[data[0]]=data;
        }
        List<string> result=new List<string>();
        result.Add("ID,Name,Age,Marks,Grade");
        for (int i = 1;i<students1.Length; i++)
        {
            string[] data = students1[i].Split(',');
            string id = data[0];
            if (marksData.ContainsKey(id))
            {
                string[] marks = marksData[id];
                result.Add(
                    $"{data[0]},{data[1]},{data[2]},{marks[1]},{marks[2]}"
                );
            }
        }
        File.WriteAllLines(outputFile,result);
        Console.WriteLine("CSV files merged successfully.");
    }
}