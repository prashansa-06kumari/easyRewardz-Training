using System;

class SortingPractice
{
    public static void Run()
    {
        Console.WriteLine("Sorting Practice");

        int[] arr = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", arr));

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}