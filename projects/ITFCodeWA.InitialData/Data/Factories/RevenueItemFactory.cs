using ITFCodeWA.Models.References;

namespace ITFCodeWA.InitialData.Data.Factories
{
    internal static class RevenueItemFactory
    {
        public static RevenueItemModel Create(string name, int groupId = 0, string comment = default!) => new() 
        {
            Name = name,
            GroupId = groupId,
            Comment = comment,
        };
    }
}