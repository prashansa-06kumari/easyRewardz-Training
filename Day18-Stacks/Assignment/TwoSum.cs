using System;
using System.Collections.Generic;

class TwoSum
{
    public static int[] FindTwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map =
            new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int required = target - arr[i];

            if (map.ContainsKey(required))
            {
                return new int[]
                {
                    map[required],
                    i
                };
            }

            map[arr[i]] = i;
        }

        return Array.Empty<int>();
    }
}