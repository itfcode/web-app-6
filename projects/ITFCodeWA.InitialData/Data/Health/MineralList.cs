using ITFCodeWA.Models.Enums;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Health
{
    public static class MineralList
    {
        public static readonly DietarySupplementModel Borum = GenerateMineral("Бор", "Borum");
        public static readonly DietarySupplementModel Calcium = GenerateMineral("Кальций", "Calcium");
        public static readonly DietarySupplementModel Chromium = GenerateMineral("Хром", "Chromium");
        public static readonly DietarySupplementModel Cobalt = GenerateMineral("Кобальт", "Cobalt");
        public static readonly DietarySupplementModel Cuprum = GenerateMineral("Медь", "Cuprum");
        public static readonly DietarySupplementModel Manganese = GenerateMineral("Марганец", "Manganese");
        public static readonly DietarySupplementModel Selenium = GenerateMineral("Селен", "Selenium");
        public static readonly DietarySupplementModel Silicium = GenerateMineral("Кремний", "Silicium");
        public static readonly DietarySupplementModel Zinc = GenerateMineral("Цинк", "Zinc");

        public static IReadOnlyList<DietarySupplementModel> All => new List<DietarySupplementModel>
        {
            Borum, Calcium, Chromium, Cobalt, Cuprum,
            Manganese, Selenium, Silicium, Zinc
        };

        private static DietarySupplementModel GenerateMineral(string name, string latin)
            => new() { Name = name, LatinName = latin, Type = DietarySupplementType.Mineral };
    }
}
