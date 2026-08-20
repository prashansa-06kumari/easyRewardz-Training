class ExceptionHandlingMethods
{
    public static void TestExceptions()
    {
        try
        {
            int[] arr={10,20,30};

            Console.WriteLine(arr[5]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Index does not exist.");
        }

        try
        {
            string str=null;

            Console.WriteLine(str.Length);
        }
        catch(NullReferenceException)
        {
            Console.WriteLine("Object is null.");
        }
    }
}