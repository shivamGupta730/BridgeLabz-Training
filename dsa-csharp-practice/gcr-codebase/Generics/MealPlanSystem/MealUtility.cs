using System.Collections.Generic;

namespace MealPlanSystem
{
    public class MealUtility<T> : IMealService<T>
        where T : IMealPlan
    {
        private List<T> meals = new List<T>();

        public void AddMeal(T meal)
        {
            meals.Add(meal);
        }

        public void PrepareAll()
        {
            foreach (T meal in meals)
            {
                meal.Prepare();
            }
        }
    }
}
