using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreams
{
    public static void Run()
    {
        try
        {
            using AnonymousPipeServerStream server =
                new AnonymousPipeServerStream(PipeDirection.Out);

            using AnonymousPipeClientStream client =
                new AnonymousPipeClientStream(
                    PipeDirection.In,
                    server.ClientSafePipeHandle
                );

            Thread writerThread = new Thread(() =>
            {
                try
                {
                    using StreamWriter writer = new StreamWriter(server);
                    writer.AutoFlush = true;

                    writer.WriteLine("Hello from writer thread.");
                    writer.WriteLine("Data sent through pipe.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Writer error: " + ex.Message);
                }
            });

            Thread readerThread = new Thread(() =>
            {
                try
                {
                    using StreamReader reader = new StreamReader(client);

                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("Reader: " + line);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Reader error: " + ex.Message);
                }
            });

            readerThread.Start();
            writerThread.Start();

            writerThread.Join();

            server.DisposeLocalCopyOfClientHandle();

            readerThread.Join();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Pipe error: " + ex.Message);
        }
    }
}