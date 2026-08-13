using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    public static void FindPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int number in arr)
        {
            int required = target - number;

            if (set.Contains(required))
            {
                Console.WriteLine(
                    $"Pair found: {required} + {number} = {target}");

                return;
            }

            set.Add(number);
        }

        Console.WriteLine("No pair found.");
    }
}