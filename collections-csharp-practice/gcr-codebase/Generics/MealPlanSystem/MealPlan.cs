using System;

namespace MealPlanSystem
{
    public interface IMealPlan
    {
        void Prepare();
    }

    public class VegetarianMeal : IMealPlan
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Vegetarian Meal");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Vegan Meal");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Keto Meal");
        }
    }
}
