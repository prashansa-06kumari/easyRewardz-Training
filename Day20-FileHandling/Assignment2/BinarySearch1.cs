class BinarySearch1
{
    public static int FindRotationPoint(int[] arr)
    {
        int l=0;
        int r=arr.Length-1;

        while(l<r)
        {
            int mid=l+(r-l)/2;

            if(arr[mid]>arr[r])
                l=mid+1;
            else
                r=mid;
        }

        return l;
    }
}