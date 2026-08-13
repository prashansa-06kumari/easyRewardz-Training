using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    public static int[] FindMaximum(int[] arr, int k)
    {
        if (arr.Length == 0 || k <= 0 || k > arr.Length)
        {
            return Array.Empty<int>();
        }

        int[] result = new int[arr.Length - k + 1];

        LinkedList<int> deque = new LinkedList<int>();

        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            while (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 &&
                   arr[deque.Last.Value] <= arr[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result[index++] = arr[deque.First.Value];
            }
        }

        return result;
    }
}