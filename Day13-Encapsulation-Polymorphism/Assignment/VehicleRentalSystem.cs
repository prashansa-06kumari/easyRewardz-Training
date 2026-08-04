using System;

namespace Assignment
{
    interface IInsurable
    {
        double CalculateInsurance();
        void GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        private string insurancePolicyNumber;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set
            {
                if (value >= 0)
                    rentalRate = value;
            }
        }

        protected Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public void SetInsurancePolicy(string policyNumber)
        {
            insurancePolicyNumber = policyNumber;
        }

        public string GetInsurancePolicy()
        {
            return insurancePolicyNumber;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Number : {VehicleNumber}");
            Console.WriteLine($"Type           : {Type}");
            Console.WriteLine($"Rental Rate    : ₹{RentalRate}/day");
        }
    }

    class Car : Vehicle, IInsurable
    {
        public Car(string vehicleNumber, double rentalRate)
            : base(vehicleNumber, "Car", rentalRate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : ₹{CalculateInsurance()}");
        }
    }

    class Bike : Vehicle, IInsurable
    {
        public Bike(string vehicleNumber, double rentalRate)
            : base(vehicleNumber, "Bike", rentalRate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : ₹{CalculateInsurance()}");
        }
    }

    class Truck : Vehicle, IInsurable
    {
        public Truck(string vehicleNumber, double rentalRate)
            : base(vehicleNumber, "Truck", rentalRate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : ₹{CalculateInsurance()}");
        }
    }
}