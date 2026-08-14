using System;

class CountingSort
{
    public static void Run()
    {
        int[] ages = { 15, 12, 18, 14, 12, 16, 15, 10 };

        int min = 10;
        int max = 18;

        int[] count = new int[max - min + 1];

        foreach (int age in ages)
        {
            count[age - min]++;
        }

        int index = 0;

        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                ages[index] = i + min;
                index++;
                count[i]--;
            }
        }

        Console.WriteLine("Sorted Student Ages:");
        Console.WriteLine(string.Join(" ", ages));
    }
}