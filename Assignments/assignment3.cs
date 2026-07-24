using System;

namespace Assignments
{
    public class assignment3
    {
        // Question 1
        public static void quotientandRemainder()
        {
            Console.Write("Enter 1st number: ");
            int num1=int.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd number: ");
            int num2=int.Parse(Console.ReadLine()!);

            int quo=num1/num2;
            int rem=num1%num2;

            Console.WriteLine($"Quotient is {quo} and remainder is {rem} of {num1} and {num2}");
        }


        // Question 2
        public static void intoperation()
        {
            Console.Write("Enter a: ");
            int a=int.Parse(Console.ReadLine()!);

            Console.Write("Enter b: ");
            int b=int.Parse(Console.ReadLine()!);

            Console.Write("Enter c: ");
            int c=int.Parse(Console.ReadLine()!);
            int op1=a+b*c;
            int op2=a*b+c;
            int op3=c+a/b;
            int op4=a%b+c;

            Console.WriteLine($"Results are {op1},{op2},{op3},{op4}");
        }


        // Question 3
        public static void doubleOpt()
        {
            Console.Write("Enter a: ");
            double a=double.Parse(Console.ReadLine()!);
            Console.Write("Enter b: ");
            double b=double.Parse(Console.ReadLine()!);
            Console.Write("Enter c: ");
            double c=double.Parse(Console.ReadLine()!);

            double op1=a+b*c;
            double op2=a*b+c;
            double op3=c+a/b;
            double op4=a%b+c;

            Console.WriteLine($"Results are {op1},{op2},{op3},{op4}");
        }


        // Question 4
        public static void ctoF()
        {
            Console.Write("Enter temperature in Celsius: ");
            double c=double.Parse(Console.ReadLine()!);
            double f=(c*9/5)+32;
            Console.WriteLine($"Celsius is {c} and Fahrenheit is {f}");
        }


        // Question 5
        public static void fToC()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double f=double.Parse(Console.ReadLine()!);
            double c=(f-32)*5/9;
            Console.WriteLine($"Fahrenheit is {f} and Celsius is {c}");
        }


        // Question 6
        public static void totalIncome()
        {
            Console.Write("Enter salary: ");
            double sal=double.Parse(Console.ReadLine()!);
            Console.Write("Enter bonus: ");
            double bon=double.Parse(Console.ReadLine()!);
            double total=sal+bon;

            Console.WriteLine($"Salary is {sal}, Bonus is {bon}, Total income is {total}");
        }


        // Question 7
        public static void swapNum()
        {
            Console.Write("Enter first number: ");
            int a=int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int b=int.Parse(Console.ReadLine()!);
            int temp=a;
            a=b;
            b=temp;

            Console.WriteLine($"After swapping numbers are {a} and {b}");
        }


        // Question 8
        public static void traveldetails()
        {
            Console.Write("Enter name: ");
            string name=Console.ReadLine()!;
            Console.Write("Enter from city: ");
            string from=Console.ReadLine()!;

            Console.Write("Enter via city: ");
            string via=Console.ReadLine()!;

            Console.Write("Enter destination city: ");
            string to=Console.ReadLine()!;
            Console.Write("Enter distance from first city to via city: ");
            double d1=double.Parse(Console.ReadLine()!);

            Console.Write("Enter distance from via city to destination: ");
            double d2=double.Parse(Console.ReadLine()!);
            Console.Write("Enter time from first city to via city: ");
            int t1=int.Parse(Console.ReadLine()!);
            Console.Write("Enter time from via city to destination: ");
            int t2=int.Parse(Console.ReadLine()!);

            double dist=d1+d2;
            int time=t1+t2;

            Console.WriteLine($"{name} travelled from {from} to {to} via {via}");
            Console.WriteLine($"Total distance is {dist} and total time is {time} minutes");
        }


        // Question 9
        public static void athleteRounds()
        {
            Console.Write("Enter side 1: ");
            double s1=double.Parse(Console.ReadLine()!);
            Console.Write("Enter side 2: ");
            double s2=double.Parse(Console.ReadLine()!);

            Console.Write("Enter side 3: ");
            double s3=double.Parse(Console.ReadLine()!);
            double peri=s1+s2+s3;
            double rounds=5000/peri;
            Console.WriteLine($"Athlete needs {rounds:F2} rounds to complete 5 km");
        }


        // Question 10
        public static void divideChoco()
        {
            Console.Write("Enter total chocolates: ");
            int choco=int.Parse(Console.ReadLine()!);
            Console.Write("Enter number of children: ");
            int child=int.Parse(Console.ReadLine()!);

            int each=choco/child;
            int rem=choco%child;

            Console.WriteLine($"Each child gets {each} chocolates and remaining chocolates are {rem}");
        }


        // Question 11
        public static void simpleInterest()
        {
            Console.Write("Enter principal: ");
            double p=double.Parse(Console.ReadLine()!);
            Console.Write("Enter rate: ");
            double r=double.Parse(Console.ReadLine()!);

            Console.Write("Enter time: ");
            double t=double.Parse(Console.ReadLine()!);


            double si=(p*r*t)/100;

            Console.WriteLine($"Simple Interest is {si}");
        }


        // Question 12
        public static void poundToKg()
        {
            Console.Write("Enter weight in pounds: ");
            double p=double.Parse(Console.ReadLine()!);

            double kg=p/2.2;

            Console.WriteLine($"Weight in pounds is {p} and weight in kg is {kg:F2}");
        }
    }
}