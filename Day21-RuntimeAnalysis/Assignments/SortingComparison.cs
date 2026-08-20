class SortingComparison
{
    public static void BubbleSort(int[] arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-i-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
    }

    public static void MergeSort(int[] arr,int l,int r)
    {
        if(l>=r)
            return;

        int mid=l+(r-l)/2;

        MergeSort(arr,l,mid);
        MergeSort(arr,mid+1,r);

        Merge(arr,l,mid,r);
    }

    static void Merge(int[] arr,int l,int mid,int r)
    {
        int[] temp=new int[r-l+1];

        int i=l;
        int j=mid+1;
        int k=0;

        while(i<=mid && j<=r)
        {
            if(arr[i]<=arr[j])
                temp[k++]=arr[i++];
            else
                temp[k++]=arr[j++];
        }

        while(i<=mid)
            temp[k++]=arr[i++];

        while(j<=r)
            temp[k++]=arr[j++];

        for(i=0;i<temp.Length;i++)
            arr[l+i]=temp[i];
    }

    public static void QuickSort(int[] arr,int l,int r)
    {
        if(l>=r)
            return;

        int p=Partition(arr,l,r);

        QuickSort(arr,l,p-1);
        QuickSort(arr,p+1,r);
    }

    static int Partition(int[] arr,int l,int r)
    {
        int pivot=arr[r];
        int i=l-1;

        for(int j=l;j<r;j++)
        {
            if(arr[j]<pivot)
            {
                i++;

                int temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }

        int t=arr[i+1];
        arr[i+1]=arr[r];
        arr[r]=t;

        return i+1;
    }
}