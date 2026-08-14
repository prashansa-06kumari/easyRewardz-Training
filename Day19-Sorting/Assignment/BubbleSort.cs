using System;

class BubbleSort
{
    public static void Run()
    {
        int[] marks = { 78, 45, 90, 62, 55 };

        for (int i = 0; i < marks.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        Console.WriteLine("Sorted Marks:");
        Console.WriteLine(string.Join(" ", marks));
    }
}