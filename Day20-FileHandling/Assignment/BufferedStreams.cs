using System;
using System.Diagnostics;
using System.IO;

class BufferedStreams
{
    public static void Run()
    {
        string src = "largefile.txt";
        string normalDest = "normalcopy.txt";
        string bufferedDest = "bufferedcopy.txt";

        if (!File.Exists(src))
        {
            Console.WriteLine("Large file does not exist.");
            return;
        }

        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        try
        {
            sw.Start();

            using (FileStream input = new FileStream(src, FileMode.Open))
            using (FileStream output = new FileStream(normalDest, FileMode.Create))
            {
                int bytes;

                while ((bytes = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytes);
                }
            }

            sw.Stop();
            long normalTime = sw.ElapsedMilliseconds;

            sw.Restart();

            using (FileStream input = new FileStream(src, FileMode.Open))
            using (FileStream output = new FileStream(bufferedDest, FileMode.Create))
            using (BufferedStream bin = new BufferedStream(input))
            using (BufferedStream bout = new BufferedStream(output))
            {
                int bytes;

                while ((bytes = bin.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bout.Write(buffer, 0, bytes);
                }
            }

            sw.Stop();
            long bufferedTime = sw.ElapsedMilliseconds;

            Console.WriteLine("Normal Stream: " + normalTime + " ms");
            Console.WriteLine("Buffered Stream: " + bufferedTime + " ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}