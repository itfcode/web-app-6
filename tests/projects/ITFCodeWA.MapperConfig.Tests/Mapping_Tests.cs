using ITFCodeWA.MapperConfig.References;
using System.Reflection;

namespace ITFCodeWA.MapperConfig.Tests
{
    public class Mapping_Tests
    {
        [Fact]
        public void Test1()
        {
            var type = Assembly
                .GetAssembly(typeof(RevenueItemMappingProfile))
                .GetType("ITFCodeWA.MapperConfig.References.FoodMappingProfile");

            var types = Assembly.GetAssembly(typeof(RevenueItemMappingProfile)).GetTypes();

            Activator.CreateInstance(type);
        }
    }
}