using System;
using System.IO;
using System.Linq;

class ByteArrayStream
{
    public static void Run()
    {
        string src = "image.jpg";
        string dest = "image_copy.jpg";

        try
        {
            if (!File.Exists(src))
            {
                Console.WriteLine("Image file does not exist.");
                return;
            }

            byte[] data = File.ReadAllBytes(src);

            using MemoryStream ms = new MemoryStream();

            ms.Write(data, 0, data.Length);

            byte[] newData = ms.ToArray();

            File.WriteAllBytes(dest, newData);

            bool same = data.SequenceEqual(newData);

            Console.WriteLine("Image copied successfully.");
            Console.WriteLine("Images are identical: " + same);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}