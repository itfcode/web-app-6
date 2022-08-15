using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class GoodGroupFactory
    {
        public static GoodGroupModel Create(string name, string comment = default!) => new() 
        {
            Name = name,
            Comment = comment,
        };
    }
}
