using System;
using System.IO;

class FilterStreams
{
    public static void Run()
    {
        string src = "input.txt";
        string dest = "lowercase.txt";

        try
        {
            if (!File.Exists(src))
            {
                Console.WriteLine("Input file does not exist.");
                return;
            }

            using FileStream input = new FileStream(src, FileMode.Open);
            using FileStream output = new FileStream(dest, FileMode.Create);

            using BufferedStream bin = new BufferedStream(input);
            using BufferedStream bout = new BufferedStream(output);

            using StreamReader reader = new StreamReader(bin);
            using StreamWriter writer = new StreamWriter(bout);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            Console.WriteLine("File converted to lowercase.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}