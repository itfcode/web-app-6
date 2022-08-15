using ITFCodeWA.Models.References;
using static ITFCodeWA.InitialData.Data.Factories.FoodGroupFactory;

namespace ITFCodeWA.InitialData.Data.Health
{
    internal class FoodGroupSet
    {
        public static FoodGroupModel GereneralGroup = Create("* Общая группа");

        private static readonly IReadOnlyList<FoodGroupModel> _all = new List<FoodGroupModel>
        {
            GereneralGroup,
            Create("Бакалея"),
            Create("Консервы"),
            Create("Молочные продукты и яйца"),
            Create("Мясо, рыба, птица"),
            Create("Напитки"),
            Create("Сладости"),
            Create("Сыры"),
            Create("Фрукты и овощи"),
            Create("Хлеб и хлебобулочные"),
        };

        public static IReadOnlyList<FoodGroupModel> All => _all;
    }
}