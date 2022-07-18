using ITFCodeWA.Models.Health.References;

namespace ITFCodeWA.InitialData.Health
{
    public static class FoodList
    {
        private static readonly IReadOnlyList<FoodModel> _foods = new List<FoodModel>
        {
            GenerateFood("Кукурузное масло", 0, 0, 0, 890),
            GenerateFood("Оливковое масло",0, 0, 0, 890),
            GenerateFood("Подсолнечное масло",0, 0, 0, 890),
            GenerateFood("Яблоко",0, 0, 0, 50),
            GenerateFood("Сахар",0, 0, 0, 50),
            GenerateFood("Майонез салатный 30%",0, 0, 0, 310),

            GenerateFood("Хлеб", 0, 0, 0, 260),
            GenerateFood("Сухарики", 0, 0, 0, 350),

            GenerateFood("Горошек консервированный", 0, 0, 0, 60),

            GenerateFood("Капуста", 0, 0, 0, 15),
            GenerateFood("Картофель", 0, 0, 0, 80),
            GenerateFood("Лук", 0, 0, 0, 20),
            GenerateFood("Морковь", 0, 0, 0, 40),
            GenerateFood("Огурцы", 0, 0, 0, 15),
        };

        public static IReadOnlyList<FoodModel> Foods => _foods;

        private static FoodModel GenerateFood(string name, decimal proteins, decimal fats, decimal carbs, decimal calories)
            => new FoodModel
            {
                Name = name,
                Proteins = proteins,
                Fats = fats,
                Carbohydrates = carbs,
                Calories = calories
            };
    }
}