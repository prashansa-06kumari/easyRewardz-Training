class TryCatchFinally
{
    public static void ReadNumber()
    {
        try
        {
            Console.Write("Enter a number: ");

            int num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: "+num);
        }
        catch(FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Number reading completed.");
        }
    }
}