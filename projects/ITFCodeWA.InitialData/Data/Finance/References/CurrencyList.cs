using ITFCodeWA.Models.References;
using static ITFCodeWA.InitialData.Data.Factories.CurrencyFactory;

namespace ITFCodeWA.InitialData.Data.Finance.References
{
    internal static class CurrencyList
    {
        public static readonly CurrencyModel Euro = Create("Евро", "EUR", 978);
        public static readonly CurrencyModel Pound = Create("Фунт стерлингов", "GBP", 826);
        public static readonly CurrencyModel Dollar = Create("Доллар США", "USD", 840);
        public static readonly CurrencyModel Grivnya = Create("Гривня", "UAH", 980);
        public static readonly CurrencyModel Ruble = Create("Российкий рубль", "RUB", 643);
        public static readonly CurrencyModel Zloty = Create("Злотый", "PLN", 985);

        public static IReadOnlyList<CurrencyModel> All => new List<CurrencyModel>
        {
            Dollar, Euro, Pound, Ruble, Zloty, Grivnya
        };
    }
}
