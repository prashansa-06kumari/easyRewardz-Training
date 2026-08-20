class BinarySearch3
{
    public static bool SearchMatrix(int[,] mat,int target)
    {
        int rows=mat.GetLength(0);
        int cols=mat.GetLength(1);

        for(int i=0;i<rows;i++)
        {
            int l=0;
            int r=cols-1;

            while(l<=r)
            {
                int mid=l+(r-l)/2;

                if(mat[i,mid]==target)
                    return true;

                if(mat[i,mid]<target)
                    l=mid+1;
                else
                    r=mid-1;
            }
        }

        return false;
    }
}