using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class FoodFactory
    {
<<<<<<< HEAD
        public static FoodModel Create(string name, int groupId, decimal proteins, decimal fats, decimal carbs, decimal calories) => new()
        {
            Name = name,
            FoodGroupId = groupId,
            Proteins = proteins,
            Fats = fats,
            Carbohydrates = carbs,
            Calories = calories
=======
        public static FoodModel Create(string name, int groupId = 0, string comment = default!) => new() 
        {
            Name = name,
            GroupId = groupId,
            Comment = comment,
>>>>>>> 1e142695dcc42e2888d9abcfd67561ef443f92f3
        };
    }
}
