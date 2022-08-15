using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Health
{
    public static class FoodList
    {
        private static readonly IReadOnlyList<FoodModel> _foods = new List<FoodModel>
        {
            GenerateFood("Кукурузное масло", 0, 0, 0, 890),
            GenerateFood("Оливковое масло", 0, 0, 0, 890),
            GenerateFood("Подсолнечное масло", 0, 0, 0, 890),

            GenerateFood("Сахар", 0, 0, 0, 400),
            GenerateFood("Майонез салатный 30%", 0, 0, 0, 310),

            GenerateFood("Хлеб", 0, 0, 0, 260),
            GenerateFood("Сухарики", 0, 0, 0, 350),

            GenerateFood("Горошек консервированный", 0, 0, 0, 60),

            GenerateFood("Кока-кола без сахара", 0, 0, 0, 0.2m),

            GenerateFood("Яблоко", 0, 0, 0, 50),
            GenerateFood("Бананы", 0, 0, 0, 90),

            GenerateFood("Капуста", 0, 0, 0, 15),
            GenerateFood("Картофель", 0, 0, 0, 80),
            GenerateFood("Лук", 0, 0, 0, 20),
            GenerateFood("Морковь", 0, 0, 0, 40),
            GenerateFood("Огурцы", 0, 0, 0, 15),
        };

        public static IReadOnlyList<FoodModel> Foods => _foods;

        private static FoodModel GenerateFood(string name, decimal proteins, decimal fats, decimal carbs, decimal calories)
            => new()
            {
                Name = name,
                Proteins = proteins,
                Fats = fats,
                Carbohydrates = carbs,
                Calories = calories
            };
    }
}