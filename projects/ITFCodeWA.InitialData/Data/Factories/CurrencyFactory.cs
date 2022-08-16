using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class CurrencyFactory
    {
<<<<<<< HEAD
        public static CurrencyModel Create(string name, string shortName, int code) => new()
        {
            Name = name,
            ShortName = shortName,
            Code = code
        };
=======
        public static CurrencyModel Create() => new();
>>>>>>> 1e142695dcc42e2888d9abcfd67561ef443f92f3
    }
}
