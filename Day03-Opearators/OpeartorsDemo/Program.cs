using System;
using System.Globalization;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a=10;
            // int b=20;

            // Console.WriteLine(a+b);

            int n=5;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for(int i=n; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            for(int i=0;i<n; i++)
            {
                for(int j=0;j<=n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}