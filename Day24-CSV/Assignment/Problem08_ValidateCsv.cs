using System;
using System.IO;
using System.Text.RegularExpressions;

class Problem08_ValidateCsv
{
    public static void Run()
    {
        string filePath = "contacts.csv";
        string[] lines=File.ReadAllLines(filePath);
        for (int i = 1; i<lines.Length; i++)
        {
            string[] data= lines[i].Split(',');
            string email =data[2];
            string phone =data[3];
            bool validEmail = Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
            bool validPhone = Regex.IsMatch(phone, @"^\d{10}$");
            if (!validEmail)
            {
                Console.WriteLine($"Row {i}:Invalid email-{email}");
            }
            if (!validPhone)
            {
                Console.WriteLine($"Row {i}:Invalid phone-{phone}");
            }
        }
    }
}