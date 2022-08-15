using ITFCodeWA.Models.References;
using static ITFCodeWA.InitialData.Data.Factories.ContractorFactory;

namespace ITFCodeWA.InitialData.Data.Finance.References
{
    internal static class ContractorList
    {
        public static readonly ContractorModel GeneralSupplyer = Create("Обычный ПОСТАВЩИК *****", $"{113356789012}");
        public static readonly ContractorModel GeneralBuyer = Create("Обычный ПОКУПАТЕЛЬ >>>> ", $"{224456789012}");

        public static IReadOnlyList<ContractorModel> All => new List<ContractorModel>
        {
            GeneralSupplyer, GeneralBuyer
        };
    }
}