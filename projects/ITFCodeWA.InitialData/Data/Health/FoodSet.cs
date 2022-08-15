using ITFCodeWA.Models.References;
using static ITFCodeWA.InitialData.Data.Factories.FoodFactory;

namespace ITFCodeWA.InitialData.Health
{
    public static class FoodSet
    {
        private static readonly IReadOnlyList<FoodModel> _all = new List<FoodModel>
        {
            Create("Кукурузное масло", 0, 0, 0, 0, 890),
            Create("Оливковое масло", 0, 0, 0, 0, 890),
            Create("Подсолнечное масло", 0, 0, 0, 0, 890),

            Create("Сахар", 0, 0, 0, 0, 400),
            Create("Майонез салатный 30%", 0,0, 0, 0, 310),

            Create("Хлеб", 0, 0, 0, 0, 260),
            Create("Сухарики", 0, 0, 0, 0, 350),

            Create("Горошек консервированный", 0, 0, 0, 0, 60),

            Create("Кока-кола без сахара", 0, 0, 0, 0, 0.2m),

            Create("Яблоко", 0, 0, 0, 0, 50),
            Create("Бананы", 0, 0, 0, 0, 90),

            Create("Капуста", 0, 0, 0, 0, 15),
            Create("Картофель", 0, 0, 0, 0, 80),
            Create("Лук", 0, 0, 0, 0, 20),
            Create("Морковь", 0, 0, 0, 0, 40),
            Create("Огурцы", 0, 0, 0, 0, 15),
        };

        public static IReadOnlyList<FoodModel> All => _all;
    }
}