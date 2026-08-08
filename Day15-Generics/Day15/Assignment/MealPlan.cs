using System;

namespace Day15
{
    interface IMealPlan
    {
        void ShowMeal();
    }

    class VegetarianMeal :IMealPlan
    {
        public void ShowMeal()
        {
            Console.WriteLine("Vegetarian Meal: Rice, Paneer, Salad");
        }
    }

    class VeganMeal: IMealPlan
    {
        public void ShowMeal()
        {
            Console.WriteLine("Vegan Meal: Rice, Vegetables, Fruits");
        }
    }

    class KetoMeal:IMealPlan
    {
        public void ShowMeal()
        {
            Console.WriteLine("Keto Meal: Eggs, Chicken, Salad");
        }
    }

    class Meal<T> where T:IMealPlan
    {
        private T meal;

        public Meal(T meal)
        {
            this.meal = meal;
        }

        public void Generate()
        {
            meal.ShowMeal();
        }
    }

    class MealHelper
    {
        public static void Validate<T>(T meal)
            where T :IMealPlan
        {
            Console.WriteLine("Meal plan is valid");
            meal.ShowMeal();
        }
    }
}