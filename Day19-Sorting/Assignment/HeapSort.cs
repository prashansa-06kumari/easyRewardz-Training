using System;

class HeapSort
{
    public static void Run()
    {
        int[] salary = { 50000, 30000, 70000, 45000, 60000 };

        for (int i = salary.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(salary, salary.Length, i);
        }

        for (int i = salary.Length - 1; i > 0; i--)
        {
            int temp = salary[0];
            salary[0] = salary[i];
            salary[i] = temp;

            Heapify(salary, i, 0);
        }

        Console.WriteLine("Sorted Salary Demands:");
        Console.WriteLine(string.Join(" ", salary));
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }
}