using System;

namespace Assignment
{
    class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Radius        : {radius}");
            Console.WriteLine($"Area          : {CalculateArea():F2}");
            Console.WriteLine($"Circumference : {CalculateCircumference():F2}");
        }
    }
}