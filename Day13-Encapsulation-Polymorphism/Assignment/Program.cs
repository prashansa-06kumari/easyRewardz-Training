using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management\n");

            Employee[] employees =
            {
                new FullTimeEmployee(101, "Prince", 60000),
                new PartTimeEmployee(102, "Rahul", 500, 20)
            };

            foreach (Employee employee in employees)
            {
                employee.AssignDepartment("IT");
                employee.DisplayDetails();
                Console.WriteLine();
            }


            Console.WriteLine("E-Commerce Platform\n");

            Product[] products =
            {
                new Electronics(1, "Laptop", 70000),
                new Clothing(2, "T-Shirt", 1500),
                new Groceries(3, "Rice", 900)
            };

            foreach (Product product in products)
            {
                product.DisplayProduct();
                Console.WriteLine($"Discount : ₹{product.CalculateDiscount()}");

                if (product is ITaxable taxable)
                {
                    taxable.GetTaxDetails();
                }

                Console.WriteLine();
            }


            Console.WriteLine("Vehicle Rental System\n");

            Vehicle[] vehicles =
            {
                new Car("HR26A1234", 2000),
                new Bike("HR26B5678", 700),
                new Truck("HR26T9999", 5000)
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                Console.WriteLine($"Rental Cost (3 Days) : ₹{vehicle.CalculateRentalCost(3)}");

                if (vehicle is IInsurable insurable)
                {
                    insurable.GetInsuranceDetails();
                }

                Console.WriteLine();
            }


            Console.WriteLine("Banking System\n");

            BankAccount[] accounts =
            {
                new SavingsAccount("SB101", "Prince", 80000),
                new CurrentAccount("CA102", "Rahul", 150000)
            };

            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine($"Interest : ₹{account.CalculateInterest()}");

                if (account is ILoanable loan)
                {
                    Console.WriteLine($"Loan Eligible : {loan.CalculateLoanEligibility()}");
                }

                Console.WriteLine();
            }            Console.WriteLine("Library Management System\n");

            LibraryItem[] items =
            {
                new Book(1, "Atomic Habits", "James Clear"),
                new Magazine(2, "Forbes", "Editorial Team"),
                new DVD(3, "Inception", "Christopher Nolan")
            };

            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration : {item.GetLoanDuration()} Days");

                if (item is IReservable reservable)
                {
                    reservable.CheckAvailability();
                }

                Console.WriteLine();
            }


            Console.WriteLine("Online Food Delivery System\n");

            FoodItem[] foodItems =
            {
                new VegItem("Paneer Tikka", 300, 2),
                new NonVegItem("Chicken Biryani", 400, 2)
            };

            foreach (FoodItem food in foodItems)
            {
                food.GetItemDetails();
                Console.WriteLine($"Total Price : ₹{food.CalculateTotalPrice()}");

                if (food is IDiscountable discount)
                {
                    discount.GetDiscountDetails();
                }

                Console.WriteLine();
            }


            Console.WriteLine("Hospital Patient Management\n");

            Patient[] patients =
            {
                new InPatient(1, "Prince", 22),
                new OutPatient(2, "Rahul", 24)
            };

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Bill : ₹{patient.CalculateBill()}");

                if (patient is IMedicalRecord record)
                {
                    record.AddRecord("General Checkup");
                    record.ViewRecords();
                }

                Console.WriteLine();
            }


            Console.WriteLine("Ride Hailing Application\n");

            RideVehicle[] rides =
            {
                new RideCar(1, "Amit", 18),
                new RideBike(2, "Rohit", 12),
                new RideAuto(3, "Suresh", 15)
            };

            foreach (RideVehicle ride in rides)
            {
                ride.GetVehicleDetails();
                Console.WriteLine($"Fare (10 Km) : ₹{ride.CalculateFare(10)}");

                if (ride is IGPS gps)
                {
                    gps.UpdateLocation("Chandigarh");
                    gps.GetCurrentLocation();
                }

                Console.WriteLine();
            }
        }
    }
}