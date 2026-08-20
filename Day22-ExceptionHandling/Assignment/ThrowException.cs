class ThrowException
{
    public static void CheckNumber(int num)
    {
        try
        {
            if(num<0)
                throw new Exception("Number cannot be negative.");

            Console.WriteLine("Number is valid.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}