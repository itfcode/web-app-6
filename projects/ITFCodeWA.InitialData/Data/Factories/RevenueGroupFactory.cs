using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class RevenueGroupFactory
    {
        public static RevenueGroupModel Create(string name, string comment = default!) => new() 
        {
            Name = name,
            Comment = comment,
        };
    }
}
