using System;

class MergeSort
{
    public static void Run()
    {
        int[] prices = { 450, 120, 800, 250, 300 };

        Sort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Book Prices:");
        Console.WriteLine(string.Join(" ", prices));
    }

    static void Sort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        Sort(arr, left, mid);
        Sort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else
            {
                temp[k] = arr[j];
                j++;
            }

            k++;
        }

        while (i <= mid)
        {
            temp[k] = arr[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            temp[k] = arr[j];
            j++;
            k++;
        }

        for (i = 0; i < temp.Length; i++)
        {
            arr[left + i] = temp[i];
        }
    }
}