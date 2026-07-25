using System;

namespace Assignments
{
    public class assignment4
    {
        // PART 1

        // Question 1 
        public static void CheckDivisibilityBy5()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine()!);
            bool isDivisible = (N % 5 == 0);
            Console.WriteLine($"Is the number {N} divisible by 5? {isDivisible}");
        }

        // Question 2 
        public static void CheckFirstIsSmallest()
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine()!);
            bool isFirstSmallest = (number1 < number2) && (number1 < number3);

            Console.WriteLine($"Is the first number the smallest? {isFirstSmallest}");
        }

        // Question 3 
        public static void CheckLargestOfThree()
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine()!);

            bool isFirstLargest = (number1 >= number2) && (number1 >= number3);
            bool isSecondLargest = (number2 >= number1) && (number2 >= number3);
            bool isThirdLargest = (number3 >= number1) && (number3 >= number2);

            Console.WriteLine($"Is the first number the largest? {isFirstLargest}");
            Console.WriteLine($"Is the second number the largest? {isSecondLargest}");
            Console.WriteLine($"Is the third number the largest? {isThirdLargest}");
        }

        // Question 4
        public static void SumOfNNaturalNumbers()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 1) // Check whether number is natural number or not.
            {
                int sum = num * (num + 1) / 2;
                Console.WriteLine($"The sum of {num} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {num} is not a natural number");
            }
        }

        // Question 5
        public static void CheckVotingEligibility()
        {
            Console.Write("Enter person's age: ");
            int age = int.Parse(Console.ReadLine()!);

            // Conditional evaluation block
            if (age >= 18)
            {
                Console.WriteLine($"The person's age is {age} and can vote.");
            }
            else
            {
                Console.WriteLine($"The person's age is {age} and cannot vote.");
            }
        }

        // Question 6
        public static void CheckNumber()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        // Question 7 
        public static void CheckSpringSeason(string[] args)
        {
            int month = 0;
            int day = 0;

            if (args != null && args.Length >= 2)
            {
                month = int.Parse(args[0]);
                day = int.Parse(args[1]);
            }
            else
            {
                Console.Write("Enter month (1-12): ");
                month = int.Parse(Console.ReadLine()!);

                Console.Write("Enter day (1-31): ");
                day = int.Parse(Console.ReadLine()!);
            }

            bool isSpring = (month == 3 && day >= 20 && day <= 31) ||
                            (month == 4 && day >= 1 && day <= 30) ||
                            (month == 5 && day >= 1 && day <= 31) ||
                            (month == 6 && day >= 1 && day <= 20);

            if (isSpring)
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }

        // Question 8
        public static void RocketCountWhile()
        {
            Console.Write("Enter starting countdown number: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\n--- Rocket Countdown Starting ---");
            while (n >= 1)
            {
                Console.WriteLine($"Time Left : {n}");
                n -= 1;
            }

            Console.WriteLine("Liftoff!");
        }

        // Question 9 
        public static void RocketCountFor()
        {
            Console.Write("Enter starting countdown number: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\n--- Rocket Countdown Starting ---");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine($"T Left {i}");
            }
            Console.WriteLine("Liftoff!");
        }
        // Question 10 
        public static void SumUntilZero()
        {
            double sum = 0.0;
            Console.Write("Enter a double value (0 to stop): ");
            double n = double.Parse(Console.ReadLine()!);
            while (n != 0)
            {
                sum += n;
                Console.Write("Enter a double value (0 to stop): ");
                n = double.Parse(Console.ReadLine()!);
            }

            Console.WriteLine($"Total sum is: {sum}");
        }

        // Question 11 
        public static void SumUntilZeroOrNegative()
        {
            double total = 0.0;
            while (true)
            {
                Console.Write("Enter a number: ");
                double input = double.Parse(Console.ReadLine()!);
                if (input <= 0)
                {
                    break;
                }
                total += input;
            }
            Console.WriteLine($"Total sum is: {total}");
        }

        // Question 12 
        public static void SumNNaturalNum()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            if (num >= 1)
            {
                int formulaSum = num * (num + 1) / 2;
                int loopSum = 0;
                int current = 1;
                while (current <= num)
                {
                    loopSum += current;
                    current++;
                }
                Console.WriteLine($"Sum using formula: {formulaSum}");
                Console.WriteLine($"Sum using while loop: {loopSum}");
                if (formulaSum == loopSum)
                {
                    Console.WriteLine("Both computations are correct and match!");
                }
            }
            else
            {
                Console.WriteLine($"The number {num} is not a natural number.");
            }
        }

        // Question 13
        public static void SumNNaturalNumbersFor()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            if (num >= 1)
            {
                int formulaSum = num * (num + 1) / 2;
                int loopSum = 0;
                for (int i = 1; i <= num; i++)
                {
                    loopSum += i;
                }
                Console.WriteLine($"Sum using formula: {formulaSum}");
                Console.WriteLine($"Sum using for loop: {loopSum}");
                if (formulaSum == loopSum)
                {
                    Console.WriteLine("Both computations are correct and match!");
                }
            }
            else
            {
                Console.WriteLine($"The number {num} is not a natural number");
            }
        }

        // Question 14 
        public static void FactorialWhile()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 1)
            {
                long fact = 1;
                int curr = 1;

                while (curr <= num)
                {
                    fact *= curr;
                    curr++;
                }

                Console.WriteLine($"The factorial of {num} is {fact}");
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        // Question 15 
        public static void FactorialFor()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine()!);
            if (num >= 1)
            {
                long fact = 1;

                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }

                Console.WriteLine($"The factorial of {num} is {fact}");
            }
            else
            {
                Console.WriteLine("Please enter a natural number.");
            }
        }

        // Question 16 
        public static void PrintOddAndEven()
        {
            Console.Write("Enter a natural number: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is Even");
                    }
                    else
                    {
                        Console.WriteLine($"{i} is Odd");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a natural number.");
            }
        }

        // Question 17 
        public static void CalculateEmployeeBonus()
        {
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine()!);

            Console.Write("Enter years of service: ");
            int Years = int.Parse(Console.ReadLine()!);

            if (Years > 5)
            {
                double bonus = salary * 0.05;
                Console.WriteLine($"Bonus amount is: {bonus}");
            }
            else
            {
                Console.WriteLine("No bonus applicable.");
            }
        }

        // Question 18 
        public static void MultiplicationTable6To9()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        // PART 2


        // Question 1
        public static void CheckLeapYear1()
        {
            Console.Write("Enter  a Year : ");
            int year = int.Parse(Console.ReadLine()!);

            if (year < 1582) // Gregorian calendar check
            {
                Console.WriteLine("Leap year program only works for year >= 1582 (Gregorian calendar).");
            }
            else
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
        }

        // Question 2 
        public static void CheckLeapYear2()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine()!);

            if (year < 1582)    // Gregorian calendar check
            {
                Console.WriteLine("Leap year program only works for year >= 1582 (Gregorian calendar).");
            }
            else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }

        // Question 3
        public static void CalculateStudentGrade()
        {
            Console.Write("Enter Physics marks: ");
            double physics = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Chemistry marks: ");
            double chemistry = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Maths marks: ");
            double maths = double.Parse(Console.ReadLine()!);
            double total = physics + chemistry + maths;
            double percentage = total / 3.0;
            string grade;
            string remarks;

            if (percentage >= 80)
            {
                grade = "A";
                remarks = "Level 4, above agency standards";
            }
            else if (percentage >= 70)
            {
                grade = "B";
                remarks = "Level 3, at agency standards";
            }
            else if (percentage >= 60)
            {
                grade = "C";
                remarks = "Level 2, below, but approaching agency standards";
            }
            else if (percentage >= 50)
            {
                grade = "D";
                remarks = "Level 1, well below agency standards";
            }
            else if (percentage >= 40)
            {
                grade = "E";
                remarks = "Level 1-, too below agency standards";
            }
            else
            {
                grade = "R";
                remarks = "Remedial standards";
            }

            Console.WriteLine("\n--- Academic Performance Summary ---");
            Console.WriteLine($"Total Marks: {total} / 300");
            Console.WriteLine($"Average Mark (Percentage): {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Remarks: {remarks}");
        }

        // Question 4 
        public static void CheckPrimeNumber()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime Number.");
            }
        }

        // Question 5 
        public static void FizzBuzzFor()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        // Question 6 
        public static void FizzBuzzWhile()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num >= 0)
            {
                int i = 0;
                while (i <= num)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        // Question 7 
        public static void CalculateBMI()
        {
            Console.Write("Enter weight (in kg): ");
            double weight = double.Parse(Console.ReadLine()!);

            Console.Write("Enter height (in cm): ");
            double heightCm = double.Parse(Console.ReadLine()!);

            double heightMeters = heightCm / 100.0;
            double bmi = weight / (heightMeters * heightMeters);

            string status;
            if (bmi < 18.5)
            {
                status = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                status = "Normal weight";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                status = "Overweight";
            }
            else
            {
                status = "Obese";
            }

            Console.WriteLine($"\nYour BMI is: {bmi:F2}");
            Console.WriteLine($"Weight Status: {status}");
        }

        // Question 8 
        public static void FindYoungestAndTallest()
        {
            Console.Write("Enter Amar's age: ");
            int ageAmar = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Amar's height (in cm): ");
            double heightAmar = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Akbar's age: ");
            int ageAkbar = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Akbar's height (in cm): ");
            double heightAkbar = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Anthony's age: ");
            int ageAnthony = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Anthony's height (in cm): ");
            double heightAnthony = double.Parse(Console.ReadLine()!);
            string youngest = "Amar";
            int minAge = ageAmar;

            if (ageAkbar < minAge)
            {
                minAge = ageAkbar;
                youngest = "Akbar";
            }
            if (ageAnthony < minAge)
            {
                minAge = ageAnthony;
                youngest = "Anthony";
            }
            string tallest = "Amar";
            double maxHeight = heightAmar;

            if (heightAkbar > maxHeight)
            {
                maxHeight = heightAkbar;
                tallest = "Akbar";
            }
            if (heightAnthony > maxHeight)
            {
                maxHeight = heightAnthony;
                tallest = "Anthony";
            }

            Console.WriteLine($"\nThe Youngest friend is: {youngest} ({minAge} years old)");
            Console.WriteLine($"The Tallest friend is: {tallest} ({maxHeight} cm)");
        }

        // Question 9 
        public static void FindGreatestFactor()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine()!);
            int gf = 1;
            for (int i = n - 1; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    gf = i;
                    break;
                }
            }
            Console.WriteLine($"The greatest factor of {n} beside itself is: {gf}");
        }

        // Question 10
        public static void FindPower()
        {
            Console.Write("Enter base number: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine()!);

            long result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            Console.WriteLine($"{number} raised to the power of {power} is: {result}");
        }

        // Question 11 
        public static void FindFactors()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Factors of {number} (excluding itself):");
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Question 12 
        public static void FindMultiplesBelow100()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Multiples of {number} below 100:");
            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        // Part 3

        //Question 1 
        public static void CheckArmstrongNumber()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine()!);

            int digitCount = 0;
            int temp = number;

            if (temp == 0)
            {
                digitCount = 1;
            }
            else
            {
                while (temp != 0)
                {
                    digitCount++;
                    temp /= 10;
                }
            }

            int sum = 0;
            int originalNumber = number;

            while (originalNumber != 0)
            {
                int r = originalNumber % 10;
                sum += (int)Math.Pow(r, digitCount);
                originalNumber /= 10;
            }

            if (number == sum)
            {
                Console.WriteLine($"{number} is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine($"{number} is Not an Armstrong Number.");
            }
        }

        // Question 2
        public static void CountDigits()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine()!);
            int temp = n;
            int count = 0;

            if (temp == 0) // Edge case for zero
            {
                count = 1;
            }
            else
            {
                while (temp != 0)    
                {
                    temp = temp / 10;
                    count++;
                }
            }
            Console.WriteLine($"The number of digits in {n} is: {count}");
        }

        // Question 3
        public static void CheckHarshadNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            int sum = 0;
            int temp = number;

            while (temp != 0)  
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;
            }

            if (sum != 0 && number % sum == 0)
            {
                Console.WriteLine($"{number} is a Harshad Number.");
            }
            else
            {
                Console.WriteLine($"{number} is Not a Harshad Number.");
            }
        }

        // Question 4
        public static void CheckAbundantNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i; // Add i to sum
                }
            }
            if (sum > number)
            {
                Console.WriteLine($"{number} is an Abundant Number.");
            }
            else
            {
                Console.WriteLine($"{number} is Not an Abundant Number.");
            }
        }

        // Question 5
        public static void DayOfWeek()
        {
            int m, d, y;
            
            Console.Write("Enter month (1-12): ");
            m = int.Parse(Console.ReadLine()!);

            Console.Write("Enter day: ");
            d = int.Parse(Console.ReadLine()!);

            Console.Write("Enter year: ");
            y = int.Parse(Console.ReadLine()!);
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine($"Day of Week Code: {d0}");
            Console.WriteLine($"Day of Week: {days[d0]}");
        }

        // Question 6
        public static void Calculator()
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine()!);

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine()!;

            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine()!);
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {first} + {second} = {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first} - {second} = {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first} * {second} = {first * second}");
                    break;
                case "/":
                    if (second != 0)
                    {
                        Console.WriteLine($"Result: {first} / {second} = {first / second}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}