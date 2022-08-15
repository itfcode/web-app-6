using ITFCodeWA.Models.Enums;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Health
{
    public static class VitaminList
    {
        public static readonly DietarySupplementModel VitaminA = GenerateVitamin("Витамин A", "VitaminA");
        public static readonly DietarySupplementModel VitaminB1 = GenerateVitamin("Витамин B1", "VitaminB1");
        public static readonly DietarySupplementModel VitaminB12 = GenerateVitamin("Витамин B12", "VitaminB12");
        public static readonly DietarySupplementModel VitaminB2 = GenerateVitamin("Витамин B2", "VitaminB2");
        public static readonly DietarySupplementModel VitaminB3 = GenerateVitamin("Витамин B3", "VitaminB3");
        public static readonly DietarySupplementModel VitaminB6 = GenerateVitamin("Витамин B6", "VitaminB6");
        public static readonly DietarySupplementModel VitaminB9 = GenerateVitamin("Витамин B9", "VitaminB9");
        public static readonly DietarySupplementModel VitaminC = GenerateVitamin("Витамин D", "VitaminC");
        public static readonly DietarySupplementModel VitaminD = GenerateVitamin("Витамин D", "VitaminD");
        public static readonly DietarySupplementModel VitaminE = GenerateVitamin("Витамин E", "VitaminE");
        public static readonly DietarySupplementModel VitaminK = GenerateVitamin("", "VitaminK");

        public static IReadOnlyList<DietarySupplementModel> All => new List<DietarySupplementModel>
        {
            VitaminA, VitaminB1, VitaminB12, VitaminB2, VitaminB3, VitaminB6, VitaminB9,
            VitaminC, VitaminD, VitaminE, VitaminK
        };

        private static DietarySupplementModel GenerateVitamin(string name, string latin)
            => new() { Name = name, LatinName = latin, Type = DietarySupplementType.Vitamin };
    }
}
