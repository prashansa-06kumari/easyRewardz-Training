using System;

namespace Practice
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    class Car : Vehicle
    {
        public sealed override void Start()
        {
            Console.WriteLine("Car Started");
        }
    }

    class SportsCar : Car
    {
        // Start() cannot be overridden here
        // because it is sealed in the Car class.
    }
    sealed class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("Performing Calculation");
        }
    }
}