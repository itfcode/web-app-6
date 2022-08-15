using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class ContractorFactory
    {
        public static ContractorModel Create(string name, string taxNumber, string comment = default!) => new() 
        {
            Name = name,
            TaxNumber = taxNumber,
            Comment = comment ?? "Создано программно",
        };
    }
}
