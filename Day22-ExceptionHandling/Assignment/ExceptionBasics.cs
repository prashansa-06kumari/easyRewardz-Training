class ExceptionBasics
{
    public static void DivideNumbers(int a,int b)
    {
        try
        {
            int ans=a/b;

            Console.WriteLine("Answer: "+ans);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}