using System;
using System.IO.Compression;

namespace MyNamespace
{
    public class assignment1
    {
       //question 1 
       public static void printWelcome()
        {
            Console.WriteLine("Welcome to Bridgelabz!");
        }


        //question 2
        public static void Add()
        {
            Console.WriteLine("Enter First number: ");
            int a=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter second number: ");
            int b=int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Sum of {a} and {b} is: {a+b}");
        }

        //question 3
        public static void Convert()
        {
            Console.WriteLine("Enter temp in celsius: ");
            int a=int.Parse(Console.ReadLine()!);
            double f= (a * 9.0/5) + 32;
            Console.WriteLine("Temprature in Fahrenheit is: "+f);
            
        }

        //question 4
        public static void AreaOfCirc()
        {
            Console.WriteLine("Enter radius of the circle: ");
            double r=double.Parse(Console.ReadLine()!);

            double area=3.14*r*r;

            Console.WriteLine($"Area of the circle with radius {r} is: "+area);
        }

        //question 5
        public static void VolOfCyl()
        {
            Console.WriteLine("Enter radius of the cylinder: ");
            double r=double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter height of the cylinder: ");
            double h=double.Parse(Console.ReadLine()!);

            double vol = 3.14*r*r*h;

            Console.WriteLine("Vol of cylinder is: "+vol);
        }


        //question 6
        public static void SimpleInterest()
        {
            Console.WriteLine("Enter Principal amount: ");
            double pri=double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter rate: ");
            double rate=double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter time: ");
            double time=double.Parse(Console.ReadLine()!);

            double si=(pri*rate*time)/100;
            Console.WriteLine("Simple Interest is: "+ si);
        }

        //question 7
        public static void perimeterOfRect()
        {
            Console.WriteLine("Enter length of rect: ");
            int len=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter width of rectangle: ");
            int w=int.Parse(Console.ReadLine()!);

            int peri=2*(len+w);
            Console.WriteLine("Perimeter of Rectangle is: "+peri);
        } 

        //question 8
        public static void powwer(){
            Console.WriteLine("Enter number: ");
            int num=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter exponent: ");
            int exp=int.Parse(Console.ReadLine()!);

            int powerr=(int)Math.Pow(num, exp);
            Console.WriteLine("Solution is: "+powerr);
        }




        //question 9
        public static void avg()
        {
           Console.WriteLine("Enter First number: ");
            int a=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter second number: ");
            int b=int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter third number: ");
            int c=int.Parse(Console.ReadLine()!);

            double average=(a+b+c)/3.0;

            Console.WriteLine("Average is: "+average);
        }


        //question 10
        public static void KilToMil()
        {
            Console.WriteLine("Enter distance in kilometeres: ");
            double km=double.Parse(Console.ReadLine()!);

            double dist=km*0.621371;

            Console.WriteLine("Distance in miles is: "+ dist);
            
        }


    }
}