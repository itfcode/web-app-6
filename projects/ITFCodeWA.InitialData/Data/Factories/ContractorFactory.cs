using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class ContractorFactory
    {
<<<<<<< HEAD
        public static ContractorModel Create(string name, string taxNumber, string comment = default!) => new() 
        {
            Name = name,
            TaxNumber = taxNumber,
            Comment = comment ?? "Создано программно",
        };
=======
        public static ContractorModel Create() => new();
>>>>>>> 1e142695dcc42e2888d9abcfd67561ef443f92f3
    }
}
