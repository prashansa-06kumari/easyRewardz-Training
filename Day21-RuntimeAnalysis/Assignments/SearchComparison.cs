class SearchComparison
{
    public static int LinearSearch(int[] arr,int target)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==target)
                return i;
        }

        return -1;
    }

    public static int BinarySearch(int[] arr,int target)
    {
        int l=0;
        int r=arr.Length-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if(arr[mid]==target)
                return mid;

            if(arr[mid]<target)
                l=mid+1;
            else
                r=mid-1;
        }

        return -1;
    }
}