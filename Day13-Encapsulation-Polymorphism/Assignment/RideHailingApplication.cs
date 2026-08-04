using System;

namespace Assignment
{
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    driverName = value;
            }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set
            {
                if (value >= 0)
                    ratePerKm = value;
            }
        }

        public Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID : {VehicleId}");
            Console.WriteLine($"Driver     : {DriverName}");
            Console.WriteLine($"Rate/Km    : ₹{RatePerKm}");
        }
    }

    class Car : Vehicle, IGPS
    {
        private string location = "Unknown";

        public Car(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {location}");
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    class Bike : Vehicle, IGPS
    {
        private string location = "Unknown";

        public Bike(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.9;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {location}");
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    class Auto : Vehicle, IGPS
    {
        private string location = "Unknown";

        public Auto(int vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm * 0.8;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {location}");
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }
}