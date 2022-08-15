using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class FoodFactory
    {
        public static FoodModel Create(string name, int groupId, decimal proteins, decimal fats, decimal carbs, decimal calories) => new()
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
