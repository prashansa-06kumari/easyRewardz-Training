using System;

namespace Practice
{
    class Restaurant
    {
        private string name;
        private string location;
        private string[] foodItems;

        public Restaurant(string name, string location, string[] foodItems)
        {
            this.name = name;
            this.location = location;
            this.foodItems = foodItems;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Restaurant Name : {name}");
            Console.WriteLine($"Location        : {location}");
            Console.WriteLine("Food Items:");

            foreach (string item in foodItems)
            {
                Console.WriteLine($"- {item}");
            }
        }

        // Check whether the given food item is available
        public bool IsFoodAvailable(string food)
        {
            foreach (string item in foodItems)
            {
                if (item.Equals(food, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}