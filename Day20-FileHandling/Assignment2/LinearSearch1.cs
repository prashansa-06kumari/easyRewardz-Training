class LinearSearch1
{
    public static int FindFirstNegative(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]<0)
                return i;
        }

        return -1;
    }
}