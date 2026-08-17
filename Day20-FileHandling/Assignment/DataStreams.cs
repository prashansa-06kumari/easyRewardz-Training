using System;
using System.IO;

class DataStreams
{
    public static void Run()
    {
        string file = "student.dat";

        try
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(101);
                writer.Write("Prashansa");
                writer.Write(8.7);
            }

            Console.WriteLine("Student data saved.");

            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int roll = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine("\nStudent Details:");
                Console.WriteLine("Roll: " + roll);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("GPA: " + gpa);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}