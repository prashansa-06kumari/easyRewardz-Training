using System;
using System.Collections.Generic;

class FindZeroSumSubarrays
{
    public static void FindSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map =
            new Dictionary<int, List<int>>();

        int sum = 0;

        map[0] = new List<int>();
        map[0].Add(-1);

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int start in map[sum])
                {
                    Console.WriteLine(
                        $"Zero sum subarray: {start + 1} to {i}");
                }
            }

            if (!map.ContainsKey(sum))
            {
                map[sum] = new List<int>();
            }

            map[sum].Add(i);
        }
    }
}