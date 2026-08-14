using System;

class QuickSort
{
    public static void Run()
    {
        int[] prices = { 450, 120, 800, 250, 300, 100 };

        Sort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        Console.WriteLine(string.Join(" ", prices));
    }

    static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);

            Sort(arr, low, pivot - 1);
            Sort(arr, pivot + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }
}