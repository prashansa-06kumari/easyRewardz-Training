using System;

namespace Assignment
{
    class Vehicle
    {
        protected int maxSpeed;
        protected string fuelType;

        // Initialize vehicle details
        public Vehicle(int maxSpeed, string fuelType)
        {
            this.maxSpeed = maxSpeed;
            this.fuelType = fuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed : {maxSpeed} km/h");
            Console.WriteLine($"Fuel Type : {fuelType}");
        }
    }

    class Car : Vehicle
    {
        private int seatCapacity;

        public Car(int maxSpeed, string fuelType, int seatCapacity)
            : base(maxSpeed, fuelType)
        {
            this.seatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity : {seatCapacity}");
        }
    }

    class Truck : Vehicle
    {
        private int payloadCapacity;

        public Truck(int maxSpeed, string fuelType, int payloadCapacity)
            : base(maxSpeed, fuelType)
        {
            this.payloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity : {payloadCapacity} kg");
        }
    }

    class Motorcycle : Vehicle
    {
        private bool hasSidecar;

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
            : base(maxSpeed, fuelType)
        {
            this.hasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar : {hasSidecar}");
        }
    }
}