using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class CurrencyFactory
    {
        public static CurrencyModel Create(string name, string shortName, int code) => new()
        {
            Name = name,
            ShortName = shortName,
            Code = code
        };
    }
}
