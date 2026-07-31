using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== this Keyword =====");

            ThisKeywordDemo student = new ThisKeywordDemo("Aarav", 21);
            student.Display();
            Console.WriteLine();

            Console.WriteLine("===== static Keyword =====");

            StaticKeywordDemo first = new StaticKeywordDemo("Ananya");
            StaticKeywordDemo second = new StaticKeywordDemo("Vikram");

            first.Display();
            second.Display();
            StaticKeywordDemo.DisplayCount();
            Console.WriteLine();

            Console.WriteLine("===== sealed Keyword =====");

            Child childObj = new Child();
            childObj.Show();

            FinalClass finalObj = new FinalClass();
            finalObj.Display();

            Console.WriteLine();

            Console.WriteLine("===== is Operator =====");

            IsOperatorDemo typeDemo = new IsOperatorDemo();
            typeDemo.CheckType();
        }
    }
}