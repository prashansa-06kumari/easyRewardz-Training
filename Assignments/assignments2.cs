using System;

using System;

namespace MyNamespace
{
    public class assignment3
    {
        public static void q1()
        {
            int birthYear=2000;
            int currentYear=2024;
            int age=currentYear-birthYear;
            Console.WriteLine($"Harry's age in {currentYear} is {age}");
        }


        public static void q2()
        {
            int maths=94;
            int phy=95;
            int chem=96;
            double avg=(maths+phy+chem)/3.0;

            Console.WriteLine($"Sam's average mark in PCM is {avg}");
        }


        public static void q3()
        {
            double km=10.8;
            double miles=km*1.6;
            Console.WriteLine($"The distance {km} km in miles is {miles}");
        }


        public static void q4()
        {
            double cp=129;
            double sp=191;
            double profit=sp-cp;
            double profitPer=profit/cp*100;
            Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}\nThe Profit is INR {profit} and Profit Percentage is {profitPer}");
        }


        public static void q5()
        {
            int pens=14;
            int stu=3;
            int each=pens/stu;
            int rem=pens%stu;

            Console.WriteLine($"Pen per student is {each} and remaining pens are {rem}");
        }


        public static void q6()
        {
            double fee=125000;
            double discountPer=10;
            double discount=fee*discountPer/100;
            double finalFee=fee-discount;
            Console.WriteLine($"Discount amount is INR {discount} and final fee is INR {finalFee}");
        }


        public static void q7()
        {
            double r=6378;
            double pi=3.14159;
            double vol=(4.0/3)*pi*r*r*r;
            Console.WriteLine($"Volume of earth is {vol} cubic km");
        }


        public static void q8()
        {
            Console.Write("Enter km: ");
            double km=double.Parse(Console.ReadLine()!);
            double miles=km/1.6;
            Console.WriteLine($"Total miles is {miles}");
        }


        public static void q9()
        {
            Console.Write("Enter fee: ");
            double fee=double.Parse(Console.ReadLine()!);
            Console.Write("Enter discount percentage: ");
            double disPer=double.Parse(Console.ReadLine()!);
            double dis=fee*disPer/100;
            double finalFee=fee-dis;

            Console.WriteLine($"Discount is {dis} and final fee is {finalFee}");
        }


        public static void q10()
        {
            Console.Write("Enter height in cm: ");
            double cm=double.Parse(Console.ReadLine()!);
            double inch=cm/2.54;
            double feet=inch/12;
            Console.WriteLine($"Height in feet is {feet} and inches is {inch}");
        }


        public static void q11()
        {
            Console.Write("Enter number1: ");
            double n1=double.Parse(Console.ReadLine()!);
            Console.Write("Enter number2: ");
            double n2=double.Parse(Console.ReadLine()!);

            double add=n1+n2;
            double sub=n1-n2;
            double mul=n1*n2;
            double div=n1/n2;
            Console.WriteLine($"{add},{sub},{mul},{div}");
        }


        public static void q12()
        {
            Console.Write("Enter base: ");
            double b=double.Parse(Console.ReadLine()!);

            Console.Write("Enter height: ");
            double h=double.Parse(Console.ReadLine()!);
            double area=0.5*b*h;
            Console.WriteLine($"Area of triangle is {area}");
        }


        public static void q13()
        {
            Console.Write("Enter perimeter: ");
            double peri=double.Parse(Console.ReadLine()!);
            double side=peri/4;
            Console.WriteLine($"Side of square is {side}");
        }


        public static void q14()
        {
            Console.Write("Enter distance in feet: ");
            double feet=double.Parse(Console.ReadLine()!);

            double yard=feet/3;
            double mile=yard/1760;
            Console.WriteLine($"Distance in yards is {yard} and miles is {mile}");
        }


        public static void q15()
        {
            Console.Write("Enter unit price: ");
            double price=double.Parse(Console.ReadLine()!);
            Console.Write("Enter quantity: ");
            int qty=int.Parse(Console.ReadLine()!);
            double total=price*qty;

            Console.WriteLine($"Total price is {total}");
        }


        public static void q16()
        {
            Console.Write("Enter students: ");
            int stu=int.Parse(Console.ReadLine()!);
            int handshake=(stu*(stu-1))/2;
            Console.WriteLine($"Maximum handshakes are {handshake}");
        }
    }
}