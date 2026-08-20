class AgeException : Exception
{
    public AgeException(string msg) : base(msg)
    {
    }
}

class CustomException
{
    public static void CheckAge(int age)
    {
        try
        {
            if(age<18)
                throw new AgeException("Age must be 18 or above.");

            Console.WriteLine("Age is valid.");
        }
        catch(AgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}