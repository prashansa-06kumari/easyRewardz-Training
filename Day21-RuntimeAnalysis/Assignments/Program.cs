using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // 1. Search Comparison

        int[] arr={1,3,5,7,9,11,13,15,17,19};
        int target=13;

        Stopwatch sw=new Stopwatch();

        sw.Start();
        int linear=SearchComparison.LinearSearch(arr,target);
        sw.Stop();

        Console.WriteLine("Linear Search Index: "+linear);
        Console.WriteLine("Linear Search Time: "+sw.ElapsedTicks);

        sw.Restart();

        int binary=SearchComparison.BinarySearch(arr,target);

        sw.Stop();

        Console.WriteLine("Binary Search Index: "+binary);
        Console.WriteLine("Binary Search Time: "+sw.ElapsedTicks);


        // 2. Sorting Comparison

        int[] a1={8,4,2,9,1,5};
        int[] a2={8,4,2,9,1,5};
        int[] a3={8,4,2,9,1,5};

        SortingComparison.BubbleSort(a1);

        SortingComparison.MergeSort(a2,0,a2.Length-1);

        SortingComparison.QuickSort(a3,0,a3.Length-1);

        Console.WriteLine("\nSorting Results:");

        Console.WriteLine("Bubble Sort:");
        Console.WriteLine(string.Join(" ",a1));

        Console.WriteLine("Merge Sort:");
        Console.WriteLine(string.Join(" ",a2));

        Console.WriteLine("Quick Sort:");
        Console.WriteLine(string.Join(" ",a3));


        // 3. String Concatenation

        int n=10000;

        sw.Restart();

        string result1=StringComparison.UsingString(n);

        sw.Stop();

        Console.WriteLine("\nString Time: "+sw.ElapsedMilliseconds+" ms");

        sw.Restart();

        string result2=StringComparison.UsingStringBuilder(n);

        sw.Stop();

        Console.WriteLine("StringBuilder Time: "+sw.ElapsedMilliseconds+" ms");


        // 4. File Reading

        string path="test.txt";

        if(File.Exists(path))
        {
            sw.Restart();

            int count1=FileReadingComparison.ReadWithStreamReader(path);

            sw.Stop();

            Console.WriteLine("\nStreamReader Characters: "+count1);
            Console.WriteLine("StreamReader Time: "+sw.ElapsedMilliseconds+" ms");

            sw.Restart();

            int count2=FileReadingComparison.ReadWithFileStream(path);

            sw.Stop();

            Console.WriteLine("FileStream Bytes: "+count2);
            Console.WriteLine("FileStream Time: "+sw.ElapsedMilliseconds+" ms");
        }
        else
        {
            Console.WriteLine("\ntest.txt not found.");
        }


        // 5. Fibonacci Comparison

        int num=30;

        sw.Restart();

        long fib1=FibonacciComparison.FibonacciRecursive(num);

        sw.Stop();

        Console.WriteLine("\nRecursive Fibonacci: "+fib1);
        Console.WriteLine("Recursive Time: "+sw.ElapsedMilliseconds+" ms");

        sw.Restart();

        long fib2=FibonacciComparison.FibonacciIterative(num);

        sw.Stop();

        Console.WriteLine("Iterative Fibonacci: "+fib2);
        Console.WriteLine("Iterative Time: "+sw.ElapsedMilliseconds+" ms");
    }
}