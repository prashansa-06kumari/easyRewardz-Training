using System;

class InsertionSort
{
    public static void Run()
    {
        int[] ids = { 105, 102, 109, 101, 107 };

        for (int i = 1; i < ids.Length; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }

            ids[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        Console.WriteLine(string.Join(" ", ids));
    }
}