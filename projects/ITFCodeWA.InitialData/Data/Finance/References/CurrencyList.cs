using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Finance.References
{
    internal static class CurrencyList
    {
        public static readonly CurrencyModel Euro = new()
        {
            Name = "Евро",
            ShortName = "EUR",
            Code = 978
        };

        public static readonly CurrencyModel Pound = new()
        {
            Name = "Фунт стерлингов",
            ShortName = "GBP",
            Code = 826
        };

        public static readonly CurrencyModel Dollar = new CurrencyModel
        {
            Name = "Доллар США",
            ShortName = "USD",
            Code = 840
        };

        public static readonly CurrencyModel Grivnya = new CurrencyModel
        {
            Name = "Гривня",
            ShortName = "UAH",
            Code = 978
        };

        public static readonly CurrencyModel Ruble = new CurrencyModel
        {
            Name = "Российкий рубль",
            ShortName = "RUB",
            Code = 643
        };

        public static readonly CurrencyModel Zloty = new CurrencyModel
        {
            Name = "Злотый",
            ShortName = "PLN",
            Code = 985
        };

        public static IReadOnlyList<CurrencyModel> All => new List<CurrencyModel>
        {
            Dollar, Euro, Pound, Ruble, Zloty, Grivnya
        };

    }
}
