class Challenge
{
    public static int FirstMissingPositive(int[] arr)
    {
        int n=arr.Length;

        for(int i=0;i<n;i++)
        {
            while(arr[i]>0 && arr[i]<=n && arr[arr[i]-1]!=arr[i])
            {
                int temp=arr[i];
                arr[i]=arr[temp-1];
                arr[temp-1]=temp;
            }
        }

        for(int i=0;i<n;i++)
        {
            if(arr[i]!=i+1)
                return i+1;
        }

        return n+1;
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