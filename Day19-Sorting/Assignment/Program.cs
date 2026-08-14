using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Bubble Sort");
        BubbleSort.Run();

        Console.WriteLine("\n2. Insertion Sort");
        InsertionSort.Run();

        Console.WriteLine("\n3. Merge Sort");
        MergeSort.Run();

        Console.WriteLine("\n4. Quick Sort");
        QuickSort.Run();

        Console.WriteLine("\n5. Selection Sort");
        SelectionSort.Run();

        Console.WriteLine("\n6. Heap Sort");
        HeapSort.Run();

        Console.WriteLine("\n7. Counting Sort");
        CountingSort.Run();
    }
}