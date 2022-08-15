using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class FoodFactory
    {
        public static FoodModel Create(string name, int groupId = 0, string comment = default!) => new() 
        {
            Name = name,
            GroupId = groupId,
            Comment = comment,
        };
    }
}
