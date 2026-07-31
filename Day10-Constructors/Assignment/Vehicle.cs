using System;

namespace Assignment
{
    class Vehicle
    {
        private string ownerName;
        private string vehicleType;

        private static double registrationFee = 5000;

        // Parameterized constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name      : {ownerName}");
            Console.WriteLine($"Vehicle Type    : {vehicleType}");
            Console.WriteLine($"Registration Fee: ₹{registrationFee}");
        }
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}