class BinarySearch4
{
    public static int FindFirst(int[] arr,int target)
    {
        int l=0;
        int r=arr.Length-1;
        int ans=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if(arr[mid]==target)
            {
                ans=mid;
                r=mid-1;
            }
            else if(arr[mid]<target)
                l=mid+1;
            else
                r=mid-1;
        }

        return ans;
    }

    public static int FindLast(int[] arr,int target)
    {
        int l=0;
        int r=arr.Length-1;
        int ans=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if(arr[mid]==target)
            {
                ans=mid;
                l=mid+1;
            }
            else if(arr[mid]<target)
                l=mid+1;
            else
                r=mid-1;
        }

        return ans;
    }
}