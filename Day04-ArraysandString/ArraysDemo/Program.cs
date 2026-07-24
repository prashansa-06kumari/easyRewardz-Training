using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[5];
            // for(int i=0; i<arr.Length; i++)
            // {
            //     Console.WriteLine($"Enter element arr[{i}]");
            // Console.WriteLine("Enter value arr[{0}]",i);
            //     arr[i]=int.Parse(Console.ReadLine()!);
            // }
            // for(int i=0; i<arr.Length; i++)
            // {
            //     Console.Write(arr[i]+" ");
            // }

            // int[] arr=new int[5];
            // for(int i=0; i < arr.Length; i++)
            // {
            //     arr[i]=int.Parse(Console.ReadLine());

            // }
            // int sum=0;
            // foreach(int num in arr)
            // {
            //     sum+=num;
                
            // }
            // Console.Write(sum);





            // int[] arr = new int[5];
            // for(int i=0; i<arr.Length; i++)
            // {
            //     arr[i]=int.Parse(Console.ReadLine());
            // }




            // int max=arr[0];

            // for(int i=1; i<arr.Length; i++)
            // {
            //     if (arr[i] > max)
            //     {
            //         max=arr[i];
            //     }
            // }
            // Console.Write("Max is "+max);





            // int min=arr[0];
            // for(int i=1; i<arr.Length; i++)
            // {
            //     if (arr[i] < min)
            //     {
            //         min=arr[i];
            //     }
            // }
            // Console.Write("Min is "+min);





            // int left=0;
            // int right=arr.Length-1;
            // while (left < right)
            // {
            //     int temp=arr[left];
            //     arr[left]=arr[right];
            //     arr[right]=temp;
            //     left++;
            //     right--;
            // }
            // for(int i=0;i<arr.Length; i++)
            // {
            //     Console.Write(arr[i]+" ");
            // }




            // int a=int.Parse(Console.ReadLine());
            // int b=int.Parse(Console.ReadLine());
            // int c=int.Parse(Console.ReadLine());

            // int sum=a+b+c;

            // if (sum == 180)
            // {
            //     Console.WriteLine("Yes");
            // }
            // else
            // {
            //     Console.WriteLine("No");
            // }



            // Console.Write("Enter a number: ");
            // int number = int.Parse(Console.ReadLine()!);

            // if (number % 5 == 0)
            // {
            //     Console.Write("Yes");
            // }
            // else
            // {
            //     Console.Write("False");
            // }
            // bool result = number % 5 == 0;
            // Console.WriteLine($"Is the number {number} divisible by 5? {result}");



            // Console.Write("Enter first number: ");
            // int num1 = int.Parse(Console.ReadLine()!);
            // Console.Write("Enter second number: ");
            // int num2 = int.Parse(Console.ReadLine()!);
            // Console.Write("Enter third number: ");
            // int num3 = int.Parse(Console.ReadLine()!);
            // bool result = num1 < num2 && num1 < num3;
            // Console.WriteLine($"Is the first number the smallest? {result}");




            // Console.Write("Enter first number: ");
            // int num1 = int.Parse(Console.ReadLine()!);
            // Console.Write("Enter second number: ");
            // int num2 = int.Parse(Console.ReadLine()!);
            // Console.Write("Enter third number: ");
            // int num3 = int.Parse(Console.ReadLine()!);

            // bool firstLargest = num1 > num2 && num1 > num3;
            // bool secondLargest = num2 > num1 && num2 > num3;
            // bool thirdLargest = num3 > num1 && num3 > num2;

            // Console.WriteLine($"Is the first number the largest? {firstLargest}");
            // Console.WriteLine($"Is the second number the largest? {secondLargest}");
            // Console.WriteLine($"Is the third number the largest? {thirdLargest}");



            // Console.Write("Enter a number: ");
            // int number = int.Parse(Console.ReadLine()!);

            // if (number > 0)
            // {
            //     int sum = number * (number + 1) / 2;
            //     Console.WriteLine($"The sum of {number} natural numbers is {sum}");
            // }
            // else
            // {
            //     Console.WriteLine($"The number {number} is not a natural number");
            // }




            // Console.Write("Enter age: ");
            // int age = int.Parse(Console.ReadLine()!); 
            // if (age >= 18)
            // {
            //     Console.WriteLine($"The person's age is {age} and can vote.");
            // }
            // else
            // {
            //     Console.WriteLine($"The person's age is {age} and cannot vote.");
            // }




            // Console.Write("Enter a number: ");
            // int number = int.Parse(Console.ReadLine()!);

            // if (number > 0)
            // {
            //     Console.WriteLine("Positive");
            // }
            // else if (number < 0)
            // {
            //     Console.WriteLine("Negative");
            // }
            // else
            // {
            //     Console.WriteLine("Zero");
            // }



            // Console.Write("Enter month: ");
            // int month = int.Parse(Console.ReadLine()!);
            // Console.Write("Enter day: ");
            // int day = int.Parse(Console.ReadLine()!);
            // if ((month == 3 && day >= 20) ||
            //     (month == 4) ||
            //     (month == 5) ||
            //     (month == 6 && day <= 20))
            // {
            //     Console.WriteLine("Its a Spring Season");
            // }
            // else
            // {
            //     Console.WriteLine("Not a Spring Season");
            // }



            // Console.Write("Enter countdown value: ");
            // int counter = int.Parse(Console.ReadLine()!);
            // while (counter >= 1)
            // {
            //     Console.WriteLine(counter);
            //     counter--;
            // }
            // Console.WriteLine("Rocket Launched!");




            // Console.Write("Enter countdown value: ");
            // int counter = int.Parse(Console.ReadLine()!);
            // for (int i = counter; i >= 1; i--)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("Rocket Launched!");


            // double total = 0.0;

            // Console.Write("Enter a number (0 to stop): ");
            // double number = double.Parse(Console.ReadLine()!);
            // while (number != 0)
            // {
            //     total += number;
            //     Console.Write("Enter a number (0 to stop): ");
            //     number = double.Parse(Console.ReadLine()!);
            // }
            // Console.WriteLine("Total = " + total);




            // double total = 0;
            // while (true)
            // {
            //     Console.Write("Enter a number: ");
            //     double number = double.Parse(Console.ReadLine()!);
            //     if (number <= 0)
            //     {
            //         break;
            //     }
            //     total += number;
            // }
            // Console.WriteLine("Total = " + total);




            // double total = 0;

            // while (true)
            // {
            //     Console.Write("Enter a number: ");
            //     double number = double.Parse(Console.ReadLine()!);

            //     if (number <= 0)
            //     {
            //         break;
            //     }

            //     total += number;
            // }

            // Console.WriteLine("Total = " + total);



            // Console.Write("Enter a natural number: ");
            // int n = int.Parse(Console.ReadLine()!);

            // if (n > 0)
            // {
            //     int sum = 0;
            //     int i = 1;

            //     while (i <= n)
            //     {
            //         sum += i;
            //         i++;
            //     }

            //     int formula = n * (n + 1) / 2;

            //     Console.WriteLine("Sum using while loop = " + sum);
            //     Console.WriteLine("Sum using formula = " + formula);

            //     if (sum == formula)
            //     {
            //         Console.WriteLine("Both results are correct.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Results are not the same.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Not a natural number.");
            // }



            //  Console.Write("Enter a positive integer: ");
            // int number = int.Parse(Console.ReadLine()!);

            // if (number >= 0)
            // {
            //     long factorial = 1;
            //     int i = 1;

            //     while (i <= number)
            //     {
            //         factorial *= i;
            //         i++;
            //     }

            //     Console.WriteLine("Factorial = " + factorial);
            // }
            // else
            // {
            //     Console.WriteLine("Please enter a positive integer.");
            // }






            







        }
    }
}
