class Program
{
    static void Main()
    {
        // Linear Search 1
        int[] arr1={5,8,3,-2,7,-9};
        int neg=LinearSearch1.FindFirstNegative(arr1);
        Console.WriteLine("First negative index: "+neg);
        // Linear Search 2
        string[] sentences=
        {
            "I like C#",
            "I am learning data structures",
            "C# is easy to learn"
        };

        int word=LinearSearch2.FindWord(sentences,"C#");

        Console.WriteLine("First sentence containing word: "+word);
        // Binary Search 1
        int[] arr2={4,5,6,7,0,1,2};

        int rotation=BinarySearch1.FindRotationPoint(arr2);

        Console.WriteLine("Rotation point: "+rotation);


        // Binary Search 2
        int[] arr3={1,3,5,4,2};

        int peak=BinarySearch2.FindPeak(arr3);

        Console.WriteLine("Peak index: "+peak);

        // Binary Search 3
        int[,] mat=
        {
            {1,3,5,7},
            {10,11,16,20},
            {23,30,34,60}
        };
        bool found=BinarySearch3.SearchMatrix(mat,16);
        Console.WriteLine("Target found in matrix: "+found);
        // Binary Search 4
        int[] arr4={1,2,2,2,3,4,5};

        int first=BinarySearch4.FindFirst(arr4,2);
        int last=BinarySearch4.FindLast(arr4,2);

        Console.WriteLine("First occurrence: "+first);
        Console.WriteLine("Last occurrence: "+last);

        int[] arr5={3,4,-1,1};

        int missing=Challenge.FirstMissingPositive(arr5);

        Console.WriteLine("First missing positive: "+missing);
        Array.Sort(arr5);

        int targetIndex=Challenge.BinarySearch(arr5,3);

        Console.WriteLine("Target index: "+targetIndex);
    }
}