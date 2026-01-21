using System;

namespace MealPlanSystem
{
    public class MealMenu
    {
        public void ShowMenu()
        {
            MealUtility<IMealPlan> mealUtility =
                new MealUtility<IMealPlan>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Add Vegetarian Meal");
                Console.WriteLine("2. Add Vegan Meal");
                Console.WriteLine("3. Add Keto Meal");
                Console.WriteLine("4. Prepare All Meals");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        mealUtility.AddMeal(new VegetarianMeal());
                        break;

                    case 2:
                        mealUtility.AddMeal(new VeganMeal());
                        break;

                    case 3:
                        mealUtility.AddMeal(new KetoMeal());
                        break;

                    case 4:
                        Console.WriteLine("\n--- Preparing Meals ---");
                        mealUtility.PrepareAll();
                        break;
                }

            } while (choice != 0);
        }
    }
}
