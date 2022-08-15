using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class FoodGroupFactory
    {
        public static FoodGroupModel Create(string name, string comment = default!) => new() 
        {
            Name = name,
            Comment = comment,
        };
    }
}
