using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. File Handling");
        FileHandling.Run();

        Console.WriteLine("\n2. Buffered Streams");
        BufferedStreams.Run();

        Console.WriteLine("\n3. Console Input");
        ConsoleInput.Run();

        Console.WriteLine("\n4. Serialization");
        Serialization.Run();

        Console.WriteLine("\n5. ByteArray Stream");
        ByteArrayStream.Run();

        Console.WriteLine("\n6. Filter Streams");
        FilterStreams.Run();

        Console.WriteLine("\n7. Data Streams");
        DataStreams.Run();

        Console.WriteLine("\n8. Piped Streams");
        PipedStreams.Run();

        Console.WriteLine("\n9. Large File Reader");
        LargeFileReader.Run();

        Console.WriteLine("\n10. Word Counter");
        WordCounter.Run();
    }
}