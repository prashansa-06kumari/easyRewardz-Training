using System;

namespace Practice
{
    // Person -> Chef, Waiter + Worker Interface

    interface Worker
    {
        void PerformDuties();
    }

    class Person
    {
        protected string name;
        protected int id;

        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }

    class Chef : Person, Worker
    {
        public Chef(string name, int id)
            : base(name, id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} prepares food.");
        }
    }

    class Waiter : Person, Worker
    {
        public Waiter(string name, int id)
            : base(name, id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} serves customers.");
        }
    }

    // Vehicle -> ElectricVehicle, PetrolVehicle + Refuelable Interface

    interface Refuelable
    {
        void Refuel();
    }

    class Vehicle
    {
        protected int maxSpeed;
        protected string model;

        public Vehicle(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }
    }

    class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(int maxSpeed, string model)
            : base(maxSpeed, model)
        {
        }

        public void Charge()
        {
            Console.WriteLine($"{model} is charging.");
        }
    }

    class PetrolVehicle : Vehicle, Refuelable
    {
        public PetrolVehicle(int maxSpeed, string model)
            : base(maxSpeed, model)
        {
        }

        public void Refuel()
        {
            Console.WriteLine($"{model} is refueling.");
        }
    }
}