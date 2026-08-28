using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public double Marks;

    public Student(int id, string name, int age, double marks)
    {
        Id = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine(
            $"ID: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}"
        );
    }
}

class Problem09_CsvToObjects
{
    public static void Run()
    {
        string filePath = "students.csv";
        string[] lines=File.ReadAllLines(filePath);
        List<Student> students = new List<Student>();
        for (int i = 1; i<lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            Student student = new Student(
                int.Parse(data[0]),
                data[1],
                int.Parse(data[2]),
                double.Parse(data[3])
            );

            students.Add(student);
        }
        foreach(Student student in students)
        {
            student.Display();
        }
    }
}