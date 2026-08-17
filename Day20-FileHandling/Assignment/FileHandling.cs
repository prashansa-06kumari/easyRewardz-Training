using System;
using System.IO;

class FileHandling
{
    public static void Run()
    {
        string src = "source.txt";
        string dest = "copy.txt";

        try
        {
            if (!File.Exists(src))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using FileStream input = new FileStream(src, FileMode.Open, FileAccess.Read);
            using FileStream output = new FileStream(dest, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[4096];
            int bytes;

            while ((bytes = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytes);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}