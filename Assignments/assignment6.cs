using System;

namespace Assignments
{
    class assignment6
    {

    //level 1
    //question-1 
    public static void SimpleInterest()
{
    Console.Write("Enter Principal: ");
    double principal = double.Parse(Console.ReadLine()!);
    Console.Write("Enter Rate: ");
    double rate = double.Parse(Console.ReadLine()!);
    Console.Write("Enter Time: ");
    double time = double.Parse(Console.ReadLine()!);
    double si = (principal * rate * time) / 100;

    Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate {rate}% and Time {time}");
}


    //question-2
    public static void HandShakes()
{
    Console.Write("Enter number of students: ");
    int n = int.Parse(Console.ReadLine()!);
    int handshakes = (n * (n - 1)) / 2;

    Console.WriteLine($"Maximum possible handshakes = {handshakes}");
}

    //question 3
    public static void AthleteRounds()
{
    Console.Write("Enter Side 1: ");
    double s1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter Side 2: ");
    double s2 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter Side 3: ");
    double s3 = double.Parse(Console.ReadLine()!);
    double perimeter = s1 + s2 + s3;
    double rounds = 5000 / perimeter;

    Console.WriteLine($"Rounds required = {Math.Ceiling(rounds)}");
}

    //question 4
    public static void CheckNumber()
{
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num > 0)
        Console.WriteLine("Positive");
    else if (num < 0)
        Console.WriteLine("Negative");
    else
        Console.WriteLine("Zero");
}


    //question 5
    public static void SpringSeason()
{
    Console.Write("Enter Month: ");
    int month = int.Parse(Console.ReadLine()!);

    Console.Write("Enter Day: ");
    int day = int.Parse(Console.ReadLine()!);

    if ((month == 3 && day >= 20) ||
        (month == 4) ||
        (month == 5) ||
        (month == 6 && day <= 20))
    {
        Console.WriteLine("Its a Spring Season");
    }
    else
    {
        Console.WriteLine("Not a Spring Season");
    }
}

    //question 6
    public static void SumNaturalNumbers()
{
    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine()!);

    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    Console.WriteLine($"Sum = {sum}");
}

    //question 7
    public static void SmallestLargest()
{
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine()!);

    Console.Write("Enter third number: ");
    int c = int.Parse(Console.ReadLine()!);

    int smallest = a;
    int largest = a;

    if (b < smallest)
        smallest = b;
    if (c < smallest)
        smallest = c;

    if (b > largest)
        largest = b;
    if (c > largest)
        largest = c;

    Console.WriteLine($"Smallest = {smallest}");
    Console.WriteLine($"Largest = {largest}");
}

//question 8
public static void QuotientRemainder()
{
    Console.Write("Enter Number: ");
    int number = int.Parse(Console.ReadLine()!);

    Console.Write("Enter Divisor: ");
    int divisor = int.Parse(Console.ReadLine()!);

    int quotient = number / divisor;
    int remainder = number % divisor;

    Console.WriteLine($"Quotient = {quotient}");
    Console.WriteLine($"Remainder = {remainder}");
}

//question 9
public static void ChocolateDistribution()
{
    Console.Write("Enter Number of Chocolates: ");
    int chocolates = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Number of Children: ");
    int children = int.Parse(Console.ReadLine()!);
    int each = chocolates / children;
    int remaining = chocolates % children;

    Console.WriteLine($"Each Child Gets = {each}");
    Console.WriteLine($"Remaining Chocolates = {remaining}");
}

//question 10
public static void WindChill()
{
    Console.Write("Enter Temperature: ");
    double temp = double.Parse(Console.ReadLine()!);

    Console.Write("Enter Wind Speed: ");
    double speed = double.Parse(Console.ReadLine()!);

    double windChill = 35.74 + (0.6215 * temp) +
                      ((0.4275 * temp) - 35.75) * Math.Pow(speed, 0.16);

    Console.WriteLine($"Wind Chill Temperature = {windChill:F2}");
}


//question 11
public static void TrigonometricFunctions()
{
    Console.Write("Enter Angle in Degrees: ");
    double angle = double.Parse(Console.ReadLine()!);

    double radians = angle * Math.PI / 180;

    Console.WriteLine($"Sin = {Math.Sin(radians)}");
    Console.WriteLine($"Cos = {Math.Cos(radians)}");
    Console.WriteLine($"Tan = {Math.Tan(radians)}");
}

//question 12
public static void Mult()
{
    Console.Write("Enter the number you want multiplication table of: ");
    int n = int.Parse(Console.ReadLine()!);
    int[] arr = new int[10];
    for (int i = 1; i <= 10; i++)
    {
        arr[i - 1] = n * i;
        Console.WriteLine($"{n} * {i} = {arr[i - 1]}");
    }
}





        //level-2
        public static void Factors()
{
    Console.Write("Enter number: ");
    int num = int.Parse(Console.ReadLine()!);
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            count++;
        }
    }
    int[] factors = new int[count];
    int index = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            factors[index] = i;
            index++;
        }
    }
    int sum = 0;
    int product = 1;
    int squareSum = 0;
    foreach(int factor in factors)
    {
        sum += factor;
        product *= factor;
        squareSum += (int)Math.Pow(factor,2);
    }
    Console.WriteLine("Factors:");
    foreach(int factor in factors)
    {
        Console.Write(factor+" ");
    }
    Console.WriteLine();
    Console.WriteLine($"Sum = {sum}");
    Console.WriteLine($"Product = {product}");
    Console.WriteLine($"Sum of Square = {squareSum}");
}

//question-2
public static void RecursiveNaturalSum()
{
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine()!);
    if(n<=0)
    {
        Console.WriteLine("Not a Natural Number");
        return;
    }
    int recursiveSum = NaturalSum(n);
    int formulaSum = n * (n + 1) / 2;
    Console.WriteLine($"Recursive Sum = {recursiveSum}");
    Console.WriteLine($"Formula Sum = {formulaSum}");
    if(recursiveSum == formulaSum)
        Console.WriteLine("Both results are correct");
    else
        Console.WriteLine("Results are different");
}
public static int NaturalSum(int n)
{
    if(n==1)
        return 1;
    return n + NaturalSum(n-1);
}


//question-3
public static void LeapYear()
{
    Console.Write("Enter Year: ");
    int year = int.Parse(Console.ReadLine()!);
    if(year < 1582)
    {
        Console.WriteLine("Invalid Year");
        return;
    }
    if(IsLeapYear(year))
        Console.WriteLine($"{year} is a Leap Year");
    else
        Console.WriteLine($"{year} is not a Leap Year");
}
public static bool IsLeapYear(int year)
{
    if((year % 400 == 0) || 
       (year % 4 == 0 && year % 100 != 0))
    {
        return true;
    }
    return false;
}


//question-4
public static void UnitConverter1()
{
    Console.WriteLine("1. KM to Miles");
    Console.WriteLine("2. Miles to KM");
    Console.WriteLine("3. Meter to Feet");
    Console.WriteLine("4. Feet to Meter");
    Console.Write("Enter choice: ");
    int choice = int.Parse(Console.ReadLine()!);
    Console.Write("Enter value: ");
    double value = double.Parse(Console.ReadLine()!);
    switch(choice)
    {
        case 1:
            Console.WriteLine(ConvertKmToMiles(value));
            break;

        case 2:
            Console.WriteLine(ConvertMilesToKm(value));
            break;

        case 3:
            Console.WriteLine(ConvertMetersToFeet(value));
            break;

        case 4:
            Console.WriteLine(ConvertFeetToMeters(value));
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
public static double ConvertKmToMiles(double km)
{
    double km2miles = 0.621371;
    return km * km2miles;
}
public static double ConvertMilesToKm(double miles)
{
    double miles2km = 1.60934;
    return miles * miles2km;
}
public static double ConvertMetersToFeet(double meters)
{
    double meters2feet = 3.28084;
    return meters * meters2feet;
}
public static double ConvertFeetToMeters(double feet)
{
    double feet2meters = 0.3048;
    return feet * feet2meters;
}



//question-5
public static void UnitConverter2()
{
    Console.WriteLine("1. Yards to Feet");
    Console.WriteLine("2. Feet to Yards");
    Console.WriteLine("3. Meters to Inches");
    Console.WriteLine("4. Inches to Meters");
    Console.WriteLine("5. Inches to Centimeters");
    Console.Write("Enter choice: ");
    int choice = int.Parse(Console.ReadLine()!);
    Console.Write("Enter value: ");
    double value = double.Parse(Console.ReadLine()!);
    switch(choice)
    {
        case 1:
            Console.WriteLine($"Feet = {ConvertYardsToFeet(value)}");
            break;

        case 2:
            Console.WriteLine($"Yards = {ConvertFeetToYards(value)}");
            break;

        case 3:
            Console.WriteLine($"Inches = {ConvertMetersToInches(value)}");
            break;

        case 4:
            Console.WriteLine($"Meters = {ConvertInchesToMeters(value)}");
            break;

        case 5:
            Console.WriteLine($"Centimeters = {ConvertInchesToCm(value)}");
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
public static double ConvertYardsToFeet(double yards)
{
    double yards2feet = 3;
    return yards * yards2feet;
}
public static double ConvertFeetToYards(double feet)
{
    double feet2yards = 0.333333;
    return feet * feet2yards;
}
public static double ConvertMetersToInches(double meters)
{
    double meters2inches = 39.3701;
    return meters * meters2inches;
}
public static double ConvertInchesToMeters(double inches)
{
    double inches2meters = 0.0254;
    return inches * inches2meters;
}
public static double ConvertInchesToCm(double inches)
{
    double inches2cm = 2.54;
    return inches * inches2cm;
}


//question-6
public static void UnitConverter3()
{
    Console.WriteLine("1. Fahrenheit to Celsius");
    Console.WriteLine("2. Celsius to Fahrenheit");
    Console.WriteLine("3. Pounds to Kilograms");
    Console.WriteLine("4. Kilograms to Pounds");
    Console.WriteLine("5. Gallons to Liters");
    Console.WriteLine("6. Liters to Gallons");
    Console.Write("Enter choice: ");
    int choice = int.Parse(Console.ReadLine()!);
    Console.Write("Enter value: ");
    double value = double.Parse(Console.ReadLine()!);
    switch(choice)
    {
        case 1:
            Console.WriteLine(ConvertFahrenheitToCelsius(value));
            break;

        case 2:
            Console.WriteLine(ConvertCelsiusToFahrenheit(value));
            break;

        case 3:
            Console.WriteLine(ConvertPoundsToKg(value));
            break;

        case 4:
            Console.WriteLine(ConvertKgToPounds(value));
            break;

        case 5:
            Console.WriteLine(ConvertGallonsToLiters(value));
            break;

        case 6:
            Console.WriteLine(ConvertLitersToGallons(value));
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}
public static double ConvertFahrenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}
public static double ConvertCelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}
public static double ConvertPoundsToKg(double pounds)
{
    double pounds2kilograms = 0.453592;
    return pounds * pounds2kilograms;
}
public static double ConvertKgToPounds(double kg)
{
    double kilograms2pounds = 2.20462;
    return kg * kilograms2pounds;
}
public static double ConvertGallonsToLiters(double gallons)
{
    double gallons2liters = 3.78541;
    return gallons * gallons2liters;
}
public static double ConvertLitersToGallons(double liters)
{
    double liters2gallons = 0.264172;
    return liters * liters2gallons;
}



//question 7
public static void StudentVoteChecker()
{
    int[] ages = new int[10];
    for(int i=0; i<ages.Length; i++)
    {
        Console.Write($"Enter age of student {i+1}: ");
        ages[i] = int.Parse(Console.ReadLine()!);
        if(CanStudentVote(ages[i]))
        {
            Console.WriteLine("Student can vote");
        }
        else
        {
            Console.WriteLine("Student cannot vote");
        }
    }
}
public static bool CanStudentVote(int age)
{
    if(age < 0)
    {
        return false;
    }
    if(age >= 18)
    {
        return true;
    }
    return false;
}



//question-8
public static void Friends()
{
    string[] names = {"Amar","Akbar","Anthony"};
    int[] ages = new int[3];
    double[] heights = new double[3];
    for(int i=0; i<3; i++)
    {
        Console.Write($"Enter age of {names[i]}: ");
        ages[i] = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter height of {names[i]}: ");
        heights[i] = double.Parse(Console.ReadLine()!);
    }
    int youngestIndex = FindYoungest(ages);
    int tallestIndex = FindTallest(heights);
    Console.WriteLine($"{names[youngestIndex]} is youngest");
    Console.WriteLine($"{names[tallestIndex]} is tallest");
}
public static int FindYoungest(int[] ages)
{
    int minIndex = 0;
    for(int i=1; i<ages.Length; i++)
    {
        if(ages[i] < ages[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}
public static int FindTallest(double[] heights)
{
    int maxIndex = 0;
    for(int i=1; i<heights.Length; i++)
    {
        if(heights[i] > heights[maxIndex])
        {
            maxIndex = i;
        }
    }
    return maxIndex;
}




//question-9
public static void NumberCheck()
{
    int[] numbers = new int[5];
    for(int i=0; i<numbers.Length; i++)
    {
        Console.Write($"Enter number {i+1}: ");
        numbers[i] = int.Parse(Console.ReadLine()!);
        if(IsPositive(numbers[i]))
        {
            Console.WriteLine("Positive");

            if(IsEven(numbers[i]))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        else
        {
            Console.WriteLine("Negative");
        }
    }
    int result = Compare(numbers[0], numbers[4]);
    if(result == 1)
    {
        Console.WriteLine("First element is greater");
    }
    else if(result == -1)
    {
        Console.WriteLine("Last element is greater");
    }
    else
    {
        Console.WriteLine("Both elements are equal");
    }
}
public static bool IsPositive(int number)
{
    return number >= 0;
}
public static bool IsEven(int number)
{
    return number % 2 == 0;
}
public static int Compare(int number1, int number2)
{
    if(number1 > number2)
    {
        return 1;
    }
    else if(number1 < number2)
    {
        return -1;
    }
    else
    {
        return 0;
    }
}


//question-10
public static void BMICalculator()
{
    double[,] persons = new double[10,3];
    for(int i=0; i<10; i++)
    {
        Console.Write($"Enter weight of person {i+1} (kg): ");
        persons[i,0] = double.Parse(Console.ReadLine()!);
        Console.Write($"Enter height of person {i+1} (cm): ");
        persons[i,1] = double.Parse(Console.ReadLine()!);
    }
    CalculateBMI(persons);
    string[] status = BMIStatus(persons);
    for(int i=0; i<10; i++)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine($"Person {i+1}");
        Console.WriteLine($"Weight : {persons[i,0]} kg");
        Console.WriteLine($"Height : {persons[i,1]} cm");
        Console.WriteLine($"BMI : {persons[i,2]:F2}");
        Console.WriteLine($"Status : {status[i]}");
    }
}
public static void CalculateBMI(double[,] persons)
{
    for(int i=0; i<10; i++)
    {
        double heightMeter = persons[i,1] / 100;
        persons[i,2] = persons[i,0] / 
                       Math.Pow(heightMeter,2);
    }
}
public static string[] BMIStatus(double[,] persons)
{
    string[] status = new string[10];
    for(int i=0; i<10; i++)
    {
        double bmi = persons[i,2];
        if(bmi < 18.5)
        {
            status[i] = "Underweight";
        }
        else if(bmi < 25)
        {
            status[i] = "Normal";
        }
        else if(bmi < 30)
        {
            status[i] = "Overweight";
        }
        else
        {
            status[i] = "Obese";
        }
    }
    return status;
}


//question-11
public static void Quadratic()
{
    Console.Write("Enter a: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("Enter b: ");
    double b = double.Parse(Console.ReadLine()!);
    Console.Write("Enter c: ");
    double c = double.Parse(Console.ReadLine()!);
    double[] roots = FindRoots(a,b,c);
    if(roots.Length == 0)
    {
        Console.WriteLine("No real roots");
    }
    else
    {
        foreach(double root in roots)
        {
            Console.WriteLine($"Root = {root}");
        }
    }
}
public static double[] FindRoots(double a,double b,double c)
{
    double delta = Math.Pow(b,2) + 4*a*c;
    if(delta > 0)
    {
        double root1 = (-b + Math.Sqrt(delta))/(2*a);
        double root2 = (-b - Math.Sqrt(delta))/(2*a);
        return new double[]{root1,root2};
    }
    else if(delta == 0)
    {
        double root = -b/(2*a);

        return new double[]{root};
    }
    else
    {
        return new double[]{};
    }
}



//question-12
public static void RandomNumbers()
{
    int[] numbers = Generate4DigitRandomArray(5);
    Console.WriteLine("Generated Numbers:");
    foreach(int num in numbers)
    {
        Console.WriteLine(num);
    }
    double[] result = FindAverageMinMax(numbers);
    Console.WriteLine($"Average = {result[0]}");
    Console.WriteLine($"Minimum = {result[1]}");
    Console.WriteLine($"Maximum = {result[2]}");
}
public static int[] Generate4DigitRandomArray(int size)
{
    int[] numbers = new int[size];
    Random random = new Random();
    for(int i=0; i<size; i++)
    {
        numbers[i] = random.Next(1000,9999);
    }
    return numbers;
}
public static double[] FindAverageMinMax(int[] numbers)
{
    double sum = 0;
    int min = numbers[0];
    int max = numbers[0];
    foreach(int num in numbers)
    {
        sum += num;
        min = Math.Min(min,num);
        max = Math.Max(max,num);
    }
    double average = sum / numbers.Length;
    return new double[]
    {
        average,
        min,
        max
    };
}





//level-3

//question-1
public static void FootballHeight()
{
    int[] heights = new int[11];
    Random random = new Random();
    for(int i=0;i<heights.Length;i++)
    {
        heights[i] = random.Next(150,251);
    }
    Console.WriteLine("Player Heights:");
    foreach(int h in heights)
    {
        Console.Write(h+" ");
    }
    Console.WriteLine();
    int sum = FindHeightSum(heights);
    double mean = FindMeanHeight(heights);
    int shortest = FindShortestHeight(heights);
    int tallest = FindTallestHeight(heights);
    Console.WriteLine($"Sum = {sum}");
    Console.WriteLine($"Mean Height = {mean}");
    Console.WriteLine($"Shortest Height = {shortest}");
    Console.WriteLine($"Tallest Height = {tallest}");
}
public static int FindHeightSum(int[] heights)
{
    int sum=0;
    foreach(int h in heights)
    {
        sum+=h;
    }
    return sum;
}
public static double FindMeanHeight(int[] heights)
{
    return FindHeightSum(heights)/heights.Length;
}
public static int FindShortestHeight(int[] heights)
{
    int min = heights[0];
    foreach(int h in heights)
    {
        if(h<min)
            min=h;
    }
    return min;
}
public static int FindTallestHeight(int[] heights)
{
    int max = heights[0];
    foreach(int h in heights)
    {
        if(h>max)
            max=h;
    }
    return max;
}



//question-2
public static void NumberCheckerBasic()
{
    Console.Write("Enter number: ");
    int number=int.Parse(Console.ReadLine()!);
    int[] digits = GetDigits(number);
    Console.WriteLine("Duck Number: "+IsDuckNumber(digits));
    Console.WriteLine("Armstrong Number: "+IsArmstrong(number,digits));
    int[] largest = FindLargestDigits(digits);
    Console.WriteLine($"Largest = {largest[0]}");
    Console.WriteLine($"Second Largest = {largest[1]}");
}
public static int CountDigits(int number)
{
    int count=0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}
public static int[] GetDigits(int number)
{
    int count=CountDigits(number);
    int[] digits=new int[count];
    for(int i=count-1;i>=0;i--)
    {
        digits[i]=number%10;
        number/=10;
    }
    return digits;
}
public static bool IsDuckNumber(int[] digits)
{
    foreach(int d in digits)
    {
        if(d!=0)
            return true;
    }
    return false;
}
public static bool IsArmstrong(int number,int[] digits)
{
    int sum=0;
    foreach(int d in digits)
    {
        sum += (int)Math.Pow(d,digits.Length);
    }
    return sum==number;
}
public static int[] FindLargestDigits(int[] digits)
{
    int first=int.MinValue;
    int second=int.MinValue;
    foreach(int d in digits)
    {
        if(d>first)
        {
            second=first;
            first=d;
        }
        else if(d>second && d!=first)
        {
            second=d;
        }
    }
    return new int[]{first,second};
}


//question-3
public static void NumberCheckerHarshad()
{
    Console.Write("Enter number: ");
    int number=int.Parse(Console.ReadLine()!);
    int[] digits=GetDigits(number);
    int sum=DigitSum(digits);
    Console.WriteLine($"Digit Sum = {sum}");
    Console.WriteLine($"Square Sum = {DigitSquareSum(digits)}");
    if(number%sum==0)
        Console.WriteLine("Harshad Number");
    else
        Console.WriteLine("Not Harshad Number");
    DigitFrequency(digits);
}
public static int DigitSum(int[] digits)
{
    int sum=0;
    foreach(int d in digits)
        sum+=d;
    return sum;
}
public static int DigitSquareSum(int[] digits)
{
    int sum=0;
    foreach(int d in digits)
        sum+=(int)Math.Pow(d,2);
    return sum;
}
public static void DigitFrequency(int[] digits)
{
    int[,] freq=new int[10,2];
    for(int i=0;i<10;i++)
    {
        freq[i,0]=i;
    }
    foreach(int d in digits)
    {
        freq[d,1]++;
    }
    for(int i=0;i<10;i++)
    {
        Console.WriteLine($"{freq[i,0]} : {freq[i,1]}");
    }
}


//question-4
public static void NumberPalindromeDuck()
{
    Console.Write("Enter number: ");
    int number=int.Parse(Console.ReadLine()!);
    int[] digits=GetDigits(number);
    int[] reverse=ReverseArray(digits);
    if(CompareArrays(digits,reverse))
        Console.WriteLine("Palindrome");
    else
        Console.WriteLine("Not Palindrome");
    Console.WriteLine("Duck Number: "+IsDuckNumber(digits));
}
public static int[] ReverseArray(int[] arr)
{
    int[] reverse=new int[arr.Length];
    for(int i=0;i<arr.Length;i++)
    {
        reverse[i]=arr[arr.Length-1-i];
    }
    return reverse;
}
public static bool CompareArrays(int[] a,int[] b)
{
    if(a.Length!=b.Length)
        return false;
    for(int i=0;i<a.Length;i++)
    {
        if(a[i]!=b[i])
            return false;
    }
    return true;
}


//question-5
public static void NumberProperties()
{
    Console.Write("Enter number: ");
    int number=int.Parse(Console.ReadLine()!);
    Console.WriteLine("Prime : "+IsPrime(number));
    Console.WriteLine("Neon : "+IsNeon(number));
    Console.WriteLine("Spy : "+IsSpy(number));
    Console.WriteLine("Automorphic : "+IsAutomorphic(number));
    Console.WriteLine("Buzz : "+IsBuzz(number));
}
public static bool IsPrime(int number)
{
    if(number<=1)
        return false;
    for(int i=2;i<number;i++)
    {
        if(number%i==0)
            return false;
    }
    return true;
}
public static bool IsNeon(int number)
{
    int square=number*number;
    int sum=0;
    while(square>0)
    {
        sum+=square%10;
        square/=10;
    }
    return sum==number;
}
public static bool IsSpy(int number)
{
    int sum=0;
    int product=1;
    while(number>0)
    {
        int digit=number%10;
        sum+=digit;
        product*=digit;
        number/=10;
    }
    return sum==product;
}
public static bool IsAutomorphic(int number)
{
    int square=number*number;
    return square.ToString().EndsWith(number.ToString());
}
public static bool IsBuzz(int number)
{
    return number%7==0 || number%10==7;
}



//question-6
public static void NumberFactors()
{
    Console.Write("Enter number: ");
    int number = int.Parse(Console.ReadLine()!);
    int[] factors = FindFactors(number);
    Console.WriteLine("Factors:");

    foreach(int f in factors)
    {
        Console.Write(f + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Greatest Factor = {GreatestFactor(factors)}");
    Console.WriteLine($"Sum of Factors = {FactorSum(factors)}");
    Console.WriteLine($"Product of Factors = {FactorProduct(factors)}");
    Console.WriteLine($"Product of Cube Factors = {CubeProduct(factors)}");
    Console.WriteLine($"Perfect Number : {IsPerfect(number,factors)}");

    Console.WriteLine($"Abundant Number : {IsAbundant(number,factors)}");

    Console.WriteLine($"Deficient Number : {IsDeficient(number,factors)}");

    Console.WriteLine($"Strong Number : {IsStrong(number)}");
}
public static int[] FindFactors(int number)
{
    int count = 0;
    for(int i=1;i<=number;i++)
    {
        if(number%i==0)
            count++;
    }
    int[] factors = new int[count];
    int index=0;
    for(int i=1;i<=number;i++)
    {
        if(number%i==0)
        {
            factors[index]=i;
            index++;
        }
    }
    return factors;
}
public static int GreatestFactor(int[] factors)
{
    return factors[factors.Length-1];
}
public static int FactorSum(int[] factors)
{
    int sum=0;
    foreach(int f in factors)
        sum+=f;
    return sum;
}
public static int FactorProduct(int[] factors)
{
    int product=1;
    foreach(int f in factors)
        product*=f;
    return product;
}
public static double CubeProduct(int[] factors)
{
    double product=1;
    foreach(int f in factors)
    {
        product*=Math.Pow(f,3);
    }
    return product;
}
public static bool IsPerfect(int number,int[] factors)
{
    int sum=0;
    for(int i=0;i<factors.Length-1;i++)
    {
        sum+=factors[i];
    }
    return sum==number;
}
public static bool IsAbundant(int number,int[] factors)
{
    int sum=0;
    for(int i=0;i<factors.Length-1;i++)
    {
        sum+=factors[i];
    }
    return sum>number;
}
public static bool IsDeficient(int number,int[] factors)
{
    int sum=0;
    for(int i=0;i<factors.Length-1;i++)
    {
        sum+=factors[i];
    }
    return sum<number;
}
public static bool IsStrong(int number)
{
    int original=number;
    int sum=0;
    while(number>0)
    {
        int digit=number%10;
        int fact=1;
        for(int i=1;i<=digit;i++)
        {
            fact*=i;
        }
        sum+=fact;
        number/=10;
    }
    return sum==original;
}



//question-7
public static void GenerateOTP()
{
    int[] otpNumbers = new int[10];
    for(int i=0;i<10;i++)
    {
        otpNumbers[i]=GenerateOTPNumber();
    }
    Console.WriteLine("Generated OTPs:");
    foreach(int otp in otpNumbers)
    {
        Console.WriteLine(otp);
    }
    if(CheckUniqueOTP(otpNumbers))
        Console.WriteLine("All OTPs are Unique");
    else
        Console.WriteLine("Duplicate OTP Found");
}
public static int GenerateOTPNumber()
{
    Random random=new Random();
    return random.Next(100000,999999);
}
public static bool CheckUniqueOTP(int[] otp)
{
    for(int i=0;i<otp.Length;i++)
    {
        for(int j=i+1;j<otp.Length;j++)
        {
            if(otp[i]==otp[j])
            {
                return false;
            }
        }
    }
    return true;
}


//question-8
public static void Calendar()
{
    Console.Write("Enter Month: ");
    int month=int.Parse(Console.ReadLine()!);
    Console.Write("Enter Year: ");
    int year=int.Parse(Console.ReadLine()!);
    Console.WriteLine(GetMonthName(month)+" "+year);
    Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
    int days=GetDays(month,year);
    int firstDay=GetFirstDay(month,year);
    for(int i=0;i<firstDay;i++)
    {
        Console.Write("    ");
    }
    for(int day=1;day<=days;day++)
    {
        Console.Write($"{day,3} ");
        if((day+firstDay)%7==0)
        {
            Console.WriteLine();
        }
    }
}
public static string GetMonthName(int month)
{
    string[] months =
    {
        "",
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
    };
    return months[month];
}
public static bool IsLeapYea(int year)
{
    return (year%400==0) ||
           (year%4==0 && year%100!=0);
}
public static int GetDays(int month,int year)
{
    int[] days =
    {
        0,31,28,31,30,31,30,
        31,31,30,31,30,31
    };
    if(month==2 && IsLeapYea(year))
        return 29;
    return days[month];
}
public static int GetFirstDay(int month,int year)
{
    int y = year - (14-month)/12;
    int x = y + y/4 - y/100 + y/400;
    int m = month + 12*((14-month)/12)-2;
    int d = (1+x+(31*m)/12)%7;
    return d;
}


//question-9
public static void EuclideanDistance()
{
    Console.Write("Enter x1: ");
    double x1=double.Parse(Console.ReadLine()!);
    Console.Write("Enter y1: ");
    double y1=double.Parse(Console.ReadLine()!);
    Console.Write("Enter x2: ");
    double x2=double.Parse(Console.ReadLine()!);
    Console.Write("Enter y2: ");
    double y2=double.Parse(Console.ReadLine()!);
    double distance=FindDistance(x1,y1,x2,y2);
    Console.WriteLine($"Distance = {distance}");
    double[] line=FindLineEquation(x1,y1,x2,y2);
    Console.WriteLine($"Slope = {line[0]}");
    Console.WriteLine($"Y Intercept = {line[1]}");
    Console.WriteLine($"Equation : y = {line[0]}x + {line[1]}");
}
public static double FindDistance(double x1,double y1,double x2,double y2)
{
    return Math.Sqrt(
        Math.Pow(x2-x1,2)+
        Math.Pow(y2-y1,2)
    );
}
public static double[] FindLineEquation(
    double x1,double y1,double x2,double y2)
{
    double slope=(y2-y1)/(x2-x1);
    double intercept=y1-(slope*x1);
    return new double[]
    {
        slope,
        intercept
    };
}


//question-10
public static void CollinearPoints()
{
    Console.Write("Enter x1: ");
    double x1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter y1: ");
    double y1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter x2: ");
    double x2 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter y2: ");
    double y2 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter x3: ");
    double x3 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter y3: ");
    double y3 = double.Parse(Console.ReadLine()!);
    bool result = CheckCollinear(x1,y1,x2,y2,x3,y3);
    if(result)
        Console.WriteLine("Points are Collinear");
    else
        Console.WriteLine("Points are Not Collinear");
}
public static bool CheckCollinear(
    double x1,double y1,
    double x2,double y2,
    double x3,double y3)
{
    double area = 0.5 *
        Math.Abs(
        x1*(y2-y3)+
        x2*(y3-y1)+
        x3*(y1-y2)
        );
    return area == 0;
}




//question-11
public static void ZaraBonus()
{
    Console.Write("Enter salary: ");
    double salary = double.Parse(Console.ReadLine()!);
    Console.Write("Enter years of service: ");
    int years = int.Parse(Console.ReadLine()!);
    double bonus = CalculateBonus(salary,years);
    Console.WriteLine($"Bonus = {bonus}");
    Console.WriteLine($"Total Salary = {salary + bonus}");
}
public static double CalculateBonus(double salary,int years)
{
    if(years >= 5)
    {
        return salary * 0.05;
    }
    return 0;
}




//question-12
public static void StudentScoreCard()
{
    Console.Write("Enter number of students: ");
    int n = int.Parse(Console.ReadLine()!);


    string[] names = new string[n];

    int[] roll = new int[n];

    double[,] marks = new double[n,3];



    for(int i=0;i<n;i++)
    {
        Console.WriteLine($"Student {i+1}");


        Console.Write("Name: ");
        names[i] = Console.ReadLine()!;


        Console.Write("Roll Number: ");
        roll[i] = int.Parse(Console.ReadLine()!);



        for(int j=0;j<3;j++)
        {
            Console.Write($"Enter subject {j+1} marks: ");
            marks[i,j] = double.Parse(Console.ReadLine()!);
        }
    }



    DisplayScoreCard(names,roll,marks);
}



public static void DisplayScoreCard(
    string[] names,
    int[] roll,
    double[,] marks)
{
    for(int i=0;i<names.Length;i++)
    {
        double total = 0;
        for(int j=0;j<3;j++)
        {
            total += marks[i,j];
        }
        double average = total/3;
        string grade = FindGrade(average);
        Console.WriteLine("--------------------");
        Console.WriteLine($"Name : {names[i]}");
        Console.WriteLine($"Roll No : {roll[i]}");
        Console.WriteLine($"Total : {total}");
        Console.WriteLine($"Average : {average}");
        Console.WriteLine($"Grade : {grade}");
    }
}
public static string FindGrade(double average)
{
    if(average >= 90)
        return "A";
    else if(average >= 80)
        return "B";
    else if(average >= 70)
        return "C";
    else if(average >= 60)
        return "D";
    return "Fail";
}



//question-13
public static void MatrixOperations()
{
    Console.Write("Enter rows: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter columns: ");
    int cols = int.Parse(Console.ReadLine()!);
    int[,] matrix1 = new int[rows,cols];
    int[,] matrix2 = new int[rows,cols];
    Console.WriteLine("Enter Matrix 1:");
    InputMatrix(matrix1);
    Console.WriteLine("Enter Matrix 2:");
    InputMatrix(matrix2);
    Console.WriteLine("Addition:");
    PrintMatrix(AddMatrix(matrix1,matrix2));
    Console.WriteLine("Subtraction:");
    PrintMatrix(SubtractMatrix(matrix1,matrix2));
    Console.WriteLine("Transpose of Matrix 1:");
    PrintMatrix(Transpose(matrix1));
}
public static void InputMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=int.Parse(Console.ReadLine()!);
        }
    }
}
public static int[,] AddMatrix(int[,] a,int[,] b)
{
    int rows=a.GetLength(0);
    int cols=a.GetLength(1);
    int[,] result=new int[rows,cols];
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<cols;j++)
        {
            result[i,j]=a[i,j]+b[i,j];
        }
    }
    return result;
}
public static int[,] SubtractMatrix(int[,] a,int[,] b)
{
    int rows=a.GetLength(0);
    int cols=a.GetLength(1);
    int[,] result=new int[rows,cols];
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<cols;j++)
        {
            result[i,j]=a[i,j]-b[i,j];
        }
    }
    return result;
}
public static int[,] Transpose(int[,] matrix)
{
    int rows=matrix.GetLength(0);
    int cols=matrix.GetLength(1);
    int[,] result=new int[cols,rows];
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<cols;j++)
        {
            result[j,i]=matrix[i,j];
        }
    }
    return result;
}
public static void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}






    }
}