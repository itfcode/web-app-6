using ITFCodeWA.Models.Enums;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Health
{
    public static class AminoAcidList
    {
        public static readonly DietarySupplementModel LArginin = GenerateAminoAcid("L-Аргинин");
        public static readonly DietarySupplementModel LCarnozin = GenerateAminoAcid("L-Карнозин");
        public static readonly DietarySupplementModel LCartinin = GenerateAminoAcid("L-Карнитин");
        public static readonly DietarySupplementModel LFenilalanin = GenerateAminoAcid("L-Фенилаланин");
        public static readonly DietarySupplementModel LGlutamin = GenerateAminoAcid("L-Глютамин");
        public static readonly DietarySupplementModel LLizin = GenerateAminoAcid("L-Лизин");
        public static readonly DietarySupplementModel LMetionin = GenerateAminoAcid("L-Метионин");
        public static readonly DietarySupplementModel LOrnitin = GenerateAminoAcid("L-Орнитин");
        public static readonly DietarySupplementModel LProlin = GenerateAminoAcid("L-Пролин");
        public static readonly DietarySupplementModel LTianin = GenerateAminoAcid("L-Тианин");
        public static readonly DietarySupplementModel LTirozin = GenerateAminoAcid("L-Тирозин");
        public static readonly DietarySupplementModel LTriptofan = GenerateAminoAcid("L-Триптофан");
        public static readonly DietarySupplementModel LZistein = GenerateAminoAcid("L-Цистеин");
        public static readonly DietarySupplementModel LZitrulin = GenerateAminoAcid("L-Цитруллин");

        public static IReadOnlyList<DietarySupplementModel> All => new List<DietarySupplementModel>
        {
            LArginin, LGlutamin, LCartinin, LCarnozin, LLizin, LMetionin, LOrnitin, 
            LProlin, LTianin, LTirozin, LTriptofan, LFenilalanin, LZistein, LZitrulin
        };

        private static DietarySupplementModel GenerateAminoAcid(string name)
            => new() { Name = name, Type = DietarySupplementType.AminoAcid };
    }
}
