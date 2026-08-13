using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ==========================================
        // 1. Queue Using Two Stacks
        // ==========================================

        Console.WriteLine("===== 1. Queue Using Stacks =====");

        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue());


        // ==========================================
        // 2. Sort Stack Using Recursion
        // ==========================================

        Console.WriteLine("\n===== 2. Sort Stack Using Recursion =====");

        Stack<int> stack = new Stack<int>();

        stack.Push(30);
        stack.Push(10);
        stack.Push(40);
        stack.Push(20);

        Console.WriteLine("Before sorting:");

        SortStackUsingRecursion.Display(stack);

        SortStackUsingRecursion.Sort(stack);

        Console.WriteLine("After sorting:");

        SortStackUsingRecursion.Display(stack);


        // ==========================================
        // 3. Stock Span Problem
        // ==========================================

        Console.WriteLine("\n===== 3. Stock Span Problem =====");

        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

        int[] span = StockSpanProblem.CalculateSpan(prices);

        Console.WriteLine("Stock spans:");

        foreach (int value in span)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();


        // ==========================================
        // 4. Sliding Window Maximum
        // ==========================================

        Console.WriteLine("\n===== 4. Sliding Window Maximum =====");

        int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };

        int k = 3;

        int[] maximums =
            SlidingWindowMaximum.FindMaximum(numbers, k);

        Console.WriteLine("Maximums:");

        foreach (int value in maximums)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();


        // ==========================================
        // 5. Circular Tour Problem
        // ==========================================

        Console.WriteLine("\n===== 5. Circular Tour Problem =====");

        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startingPoint =
            CircularTourProblem.FindStartingPoint(
                petrol,
                distance);

        Console.WriteLine(
            "Starting petrol pump: " + startingPoint);


        // ==========================================
        // 6. Find Zero Sum Subarrays
        // ==========================================

        Console.WriteLine("\n===== 6. Zero Sum Subarrays =====");

        int[] zeroSumArray = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

        FindZeroSumSubarrays.FindSubarrays(zeroSumArray);


        // ==========================================
        // 7. Pair With Given Sum
        // ==========================================

        Console.WriteLine("\n===== 7. Pair With Given Sum =====");

        int[] pairArray = { 2, 7, 11, 15 };

        PairWithGivenSum.FindPair(pairArray, 9);


        // ==========================================
        // 8. Longest Consecutive Sequence
        // ==========================================

        Console.WriteLine("\n===== 8. Longest Consecutive Sequence =====");

        int[] consecutiveArray =
        {
            100, 4, 200, 1, 3, 2
        };

        int longest =
            LongestConsecutiveSequence.FindLongest(
                consecutiveArray);

        Console.WriteLine(
            "Longest consecutive sequence length: "
            + longest);


        // ==========================================
        // 9. Custom Hash Map
        // ==========================================

        Console.WriteLine("\n===== 9. Custom Hash Map =====");

        CustomHashMap customMap =
            new CustomHashMap(10);

        customMap.Put(1, "Apple");
        customMap.Put(2, "Banana");
        customMap.Put(11, "Mango");

        Console.WriteLine(
            "Key 1: " + customMap.Get(1));

        Console.WriteLine(
            "Key 2: " + customMap.Get(2));

        Console.WriteLine(
            "Key 11: " + customMap.Get(11));

        customMap.Remove(2);

        Console.WriteLine(
            "Key 2 after removal: "
            + customMap.Get(2));


        // ==========================================
        // 10. Two Sum
        // ==========================================

        Console.WriteLine("\n===== 10. Two Sum =====");

        int[] twoSumArray =
        {
            2, 7, 11, 15
        };

        int target = 9;

        int[] result =
            TwoSum.FindTwoSum(
                twoSumArray,
                target);

        if (result.Length == 2)
        {
            Console.WriteLine(
                $"Indices: {result[0]}, {result[1]}");

            Console.WriteLine(
                $"Values: {twoSumArray[result[0]]} + " +
                $"{twoSumArray[result[1]]} = {target}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }


        Console.WriteLine("\n===== All Assignments Completed =====");
    }
}