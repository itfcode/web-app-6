using ITFCodeWA.BasisTests;
using ITFCodeWA.Models.References;
using System.Reflection;

namespace ITFCodeWA.Models.Tests
{
    public class StructureRulesUnitTests : BasisUnitTests
    {
        private static readonly IReadOnlyList<Type> _common = GetAssemlyClasses(typeof(PersonModel), "ITFCodeWA.Models.Common");

        private static readonly IReadOnlyList<Type> _finance = GetAssemlyClasses(typeof(PersonModel), "ITFCodeWA.Models.Finance");

        private static readonly IReadOnlyList<Type> _health = GetAssemlyClasses(typeof(PersonModel), "ITFCodeWA.Models.Health");

        [Fact]
        public void Test1()
        {
            var all = new List<Type>(_common.Concat(_finance).Concat(_health));

            foreach (var type in all)
            {
                Assert.Contains("Model", type.Name);
                var properties = GetPublicProperties(type);
                foreach (var property in properties)
                {
                    var attributes = property.CustomAttributes;
                    Assert.True(attributes.Any(), $"Type '{type.Name}': Property '{property.Name}' has no any attribute");
                }
            }
        }


    }
}