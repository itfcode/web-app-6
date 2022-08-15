using ITFCodeWA.Models.Enums;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class DietarySupplementFactory
    {
        public static DietarySupplementModel CreateAminoAcid(string name) => new()
        {
            Name = name,
            Type = DietarySupplementType.AminoAcid
        };

        public static DietarySupplementModel CreateMineral(string name, string latin) => new()
        {
            Name = name,
            LatinName = latin,
            Type = DietarySupplementType.Mineral
        };

        public static DietarySupplementModel CreateVitamin(string name, string latin) => new()
        {
            Name = name,
            LatinName = latin,
            Type = DietarySupplementType.Vitamin
        };
    }
}
