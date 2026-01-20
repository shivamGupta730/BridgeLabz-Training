namespace MealPlanSystem
{
    public interface IMealService<T>
    {
        void AddMeal(T meal);
        void PrepareAll();
    }
}
