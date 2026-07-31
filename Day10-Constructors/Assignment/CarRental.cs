using System;

namespace Assignment
{
    class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double totalCost;
        private const double RentPerDay = 1500;

        // Default constructor
        public CarRental()
        {
            customerName = "Unknown";
            carModel = "Not Assigned";
            rentalDays = 0;
            CalculateTotalCost();
        }
        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            CalculateTotalCost();
        }
        private void CalculateTotalCost()
        {
            totalCost = rentalDays * RentPerDay;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Car Model     : {carModel}");
            Console.WriteLine($"Rental Days   : {rentalDays}");
            Console.WriteLine($"Total Cost    : ₹{totalCost}");
        }
    }
}