using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class FoodFactory
    {
        public static FoodModel Create(string name, int groupId, int proteins, int fats, int carbs, decimal calories) => new()
        {
            Name = name,
            FoodGroupId = groupId,
            Proteins = proteins,
            Fats = fats,
            Carbohydrates = carbs,
            Calories = calories
        };
    }
}
