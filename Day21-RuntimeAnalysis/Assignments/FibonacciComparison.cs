class FibonacciComparison
{
    public static long FibonacciRecursive(int n)
    {
        if(n<=1)
            return n;

        return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);
    }

    public static long FibonacciIterative(int n)
    {
        if(n<=1)
            return n;

        long a=0;
        long b=1;

        for(int i=2;i<=n;i++)
        {
            long sum=a+b;
            a=b;
            b=sum;
        }

        return b;
    }
}