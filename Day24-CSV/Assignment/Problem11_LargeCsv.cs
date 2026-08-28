using System;
using System.IO;

class Problem11_LargeCsv
{
    public static void Run()
    {
        string filePath = "large.csv";
        using StreamReader reader = new StreamReader(filePath);
        string line;
        int batchSize=100;
        int batchCount=0;
        int totalRecords = 0;
        reader.ReadLine();
        while (true)
        {
            batchCount = 0;
            while (batchCount < batchSize &&
                   (line = reader.ReadLine()) != null)
            {
                totalRecords++;
                batchCount++;
            }
            if (batchCount == 0)
            {
                break;
            }
            Console.WriteLine(
                $"Processed records: {totalRecords}"
            );
        }
        Console.WriteLine(
            $"Total records processed: {totalRecords}"
        );
    }
}