using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Finance.References
{
    internal static class ContractorList
    {
        public static ContractorModel GeneralSupplyer = new()
        {
            Name = "Обычный ПОСТАВЩИК *****",
            TaxNumber = $"{113356789012}",
            Comment = "Создано программно"
        };

        public static ContractorModel GeneralBuyer = new()
        {
            Name = "Обычный ПОКУПАТЕЛЬ >>>>",
            TaxNumber = $"{224456789012}",
            Comment = "Создано программно"
        };

        public static IReadOnlyList<ContractorModel> All => new List<ContractorModel>
        {
            GeneralSupplyer, GeneralBuyer
        };
    }
}