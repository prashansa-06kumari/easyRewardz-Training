using System;

namespace Assignments
{
    class assignment8
    {
        // Question 1
        public static void TimeZones()
        {
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            Console.WriteLine("GMT : " + utcNow);
            DateTimeOffset ist = ConvertToIST(utcNow);
            Console.WriteLine("IST : " + ist);
            DateTimeOffset pst = ConvertToPST(utcNow);
            Console.WriteLine("PST : " + pst);
        }
        public static DateTimeOffset ConvertToIST(DateTimeOffset utcTime)
        {
            return utcTime.ToOffset(TimeSpan.FromHours(5.5));
        }
        public static DateTimeOffset ConvertToPST(DateTimeOffset utcTime)
        {
            return utcTime.ToOffset(TimeSpan.FromHours(-8));
        }

        // Question 2
        public static void DateArithmetic()
        {
            Console.Write("Enter Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);

            date = AddValues(date);
            date = SubtractWeeks(date, 3);

            Console.WriteLine("Final Date : " + date.ToString("dd/MM/yyyy"));
        }
        public static DateTime AddValues(DateTime date)
        {
            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);
            Console.WriteLine("After Addition : " + date.ToString("dd/MM/yyyy"));
            return date;
        }
        public static DateTime SubtractWeeks(DateTime date, int weeks)
        {
            return date.AddDays(-7 * weeks);
        }

        // Question 3
        public static void DateFormatting()
        {
            DateTime now = DateTime.Now;

            PrintFormat(now, "dd/MM/yyyy");
            PrintFormat(now, "yyyy-MM-dd");
            PrintFormat(now, "ddd, MMM dd, yyyy");
        }

        public static void PrintFormat(DateTime date, string format)
        {
            Console.WriteLine(date.ToString(format));
        }

        // Question 4
        public static void DateComparison()
        {
            Console.Write("Enter First Date (dd/MM/yyyy): ");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);
            Console.Write("Enter Second Date (dd/MM/yyyy): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);

            CompareDates(date1, date2);
        }

        public static void CompareDates(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("First date is before Second date");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after Second date");
            }
            else
            {
                Console.WriteLine("Both dates are same");
            }
        }


        //question-1
         public static void NumberGuessingGame()
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Type:");
            Console.WriteLine("high - if guess is too high");
            Console.WriteLine("low - if guess is too low");
            Console.WriteLine("correct - if guess is correct");

            int low = 1;
            int high = 100;

            while (true)
            {
                int guess = GenerateGuess(low, high);
                Console.WriteLine("Computer Guess: " + guess);

                string feedback = GetFeedback();

                if (feedback == "correct")
                {
                    Console.WriteLine("Computer guessed correctly!");
                    break;
                }
                else if (feedback == "high")
                {
                    high = guess - 1;
                }
                else if (feedback == "low")
                {
                    low = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        public static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        public static string GetFeedback()
        {
            Console.Write("Enter feedback: ");
            return Console.ReadLine()!.ToLower();
        }

        //question-2

        public static void MaximumOfThree()
        {
            int a = InputNumber("Enter First Number: ");
            int b = InputNumber("Enter Second Number: ");
            int c = InputNumber("Enter Third Number: ");
            int max = FindMaximum(a, b, c);

            Console.WriteLine("Maximum = " + max);
        }
        public static int InputNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine()!);
        }
        public static int FindMaximum(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }

        // question 3
        public static void PrimeChecker()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine()!);
            if (IsPrime(number))
                Console.WriteLine(number + " is Prime");
            else
                Console.WriteLine(number + " is Not Prime");
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }


        //question-4
        public static void Fibonacci()
        {
            Console.Write("Enter number of terms: ");
            int terms = int.Parse(Console.ReadLine()!);
            PrintFibonacci(terms);
        }
        public static void PrintFibonacci(int terms)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }

        // question-5

        public static void PalindromeChecker()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine()!;
            if (IsPalindrome(text))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
        public static bool IsPalindrome(string text)
        {
            text = text.ToLower();
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                if (text[left] != text[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        //question-6
        public static void Factorial()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            long result = FindFactorial(number);
            Console.WriteLine("Factorial = " + result);
        }
        public static long FindFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * FindFactorial(n - 1);
        }


        //question-7
        public static void GCDLCM()
        {
            Console.Write("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine()!);
            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2);
            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }
        public static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
        public static int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }

        //question-8

        public static void TemperatureConverter()
        {
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Temperature: ");
            double temperature = double.Parse(Console.ReadLine()!);
            if (choice == 1)
            {
                Console.WriteLine("Fahrenheit = " +
                    CelsiusToFahrenheit(temperature));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Celsius = " +
                    FahrenheitToCelsius(temperature));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        // question-9
        public static void Calculator()
        {
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}