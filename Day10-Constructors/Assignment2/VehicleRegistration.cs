using System;

namespace Assignment2
{
    class VehicleRegistration
    {
        public static double RegistrationFee = 5000;

        private string ownerName;
        private string vehicleType;
        public readonly string RegistrationNumber;

        // Parameterized constructor
        public VehicleRegistration(string ownerName, string vehicleType, string registrationNumber)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            RegistrationNumber = registrationNumber;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Owner Name          : {ownerName}");
            Console.WriteLine($"Vehicle Type        : {vehicleType}");
            Console.WriteLine($"Registration Number : {RegistrationNumber}");
            Console.WriteLine($"Registration Fee    : ₹{RegistrationFee}");
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
    }
}