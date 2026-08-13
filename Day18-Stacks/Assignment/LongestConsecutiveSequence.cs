using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);

        int longest = 0;

        foreach (int number in set)
        {
            if (!set.Contains(number - 1))
            {
                int current = number;
                int length = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}