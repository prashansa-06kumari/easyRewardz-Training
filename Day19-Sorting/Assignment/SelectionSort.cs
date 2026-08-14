using System;

class SelectionSort
{
    public static void Run()
    {
        int[] scores = { 85, 42, 91, 67, 55 };

        for (int i = 0; i < scores.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[j] < scores[min])
                {
                    min = j;
                }
            }

            int temp = scores[i];
            scores[i] = scores[min];
            scores[min] = temp;
        }

        Console.WriteLine("Sorted Exam Scores:");
        Console.WriteLine(string.Join(" ", scores));
    }
}