class Program
{
    static void Main()
    {
        Console.WriteLine("Exception Handling Assignment");

        // 1. Basic Try Catch
        ExceptionBasics.DivideNumbers(10,2);
        ExceptionBasics.DivideNumbers(10,0);


        // 2. Custom Exception
        CustomException.CheckAge(20);
        CustomException.CheckAge(15);


        // 3. Try Catch Finally
        TryCatchFinally.ReadNumber();


        // 4. Throw Exception
        ThrowException.CheckNumber(-5);
        ThrowException.CheckNumber(10);


        // 5. Different Exception Types
        ExceptionHandlingMethods.TestExceptions();
    }
}