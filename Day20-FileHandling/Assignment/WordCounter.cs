using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCounter
{
    public static void Run()
    {
        string file = "words.txt";

        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            Dictionary<string, int> words = new Dictionary<string, int>();

            using StreamReader reader = new StreamReader(file);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] arr = line.Split(
                    new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string word in arr)
                {
                    string w = word.ToLower();

                    if (words.ContainsKey(w))
                        words[w]++;
                    else
                        words[w] = 1;
                }
            }

            Console.WriteLine("Top 5 most frequent words:");

            foreach (var item in words.OrderByDescending(x => x.Value).Take(5))
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}