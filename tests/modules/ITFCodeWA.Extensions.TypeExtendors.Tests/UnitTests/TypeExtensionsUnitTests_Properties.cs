namespace ITFCodeWA.Extensions.TypeExtendors.Tests.UnitTests
{
    using ITFCodeWA.Extensions.TypeExtendors;
    using ITFCodeWA.Extensions.TypeExtendors.Tests.Classes;
    using ITFCodeWA.Extensions.TypeExtendors.Tests.TestData;
    using Newtonsoft.Json;
    using System.Reflection;

    public partial class TypeExtensionsUnitTests
    {
        public static IEnumerable<object[]> GetStaticProperties_Data => TypeExtensionsTestData.ForGetStaticProperties;
        public static IEnumerable<object[]> GetPublicStaticProperties_Data => TypeExtensionsTestData.ForGetStaticPublicProperties;
        public static IEnumerable<object[]> GetNonPublicStaticProperties_Data => TypeExtensionsTestData.ForGetStaticNonPublicProperties;

        public static IEnumerable<object[]> GetNonStaticProperties_Data => TypeExtensionsTestData.ForGetNonStaticProperties;
        public static IEnumerable<object[]> GetPublicNonStaticProperties_Data => TypeExtensionsTestData.ForGetNonStaticPublicProperties;
        public static IEnumerable<object[]> GetNonPublicNonStaticProperties_Data => TypeExtensionsTestData.ForGetNonStaticNonPublicProperties;

        [Theory]
        [MemberData(nameof(GetStaticProperties_Data))]
        public void GetStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetStaticProperties(canRead, canWrite), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetPublicStaticProperties_Data))]
        public void GetPublicStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetPublicStaticProperties(canRead, canWrite), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonPublicStaticProperties_Data))]
        public void GetNonPublicStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetNonPublicStaticProperties(canRead, canWrite), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonStaticProperties_Data))]
        public void GetNonStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetNonStaticProperties(canRead, canWrite), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetPublicNonStaticProperties_Data))]
        public void GetPublicNonStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetPublicNonStaticProperties(canRead, canWrite), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonPublicNonStaticProperties_Data))]
        public void GetNonPublicNonStaticProperties_Test(bool? canRead, bool? canWrite, string[] contained, string[] notcontained)
            => DoProperty_Test(_type.GetNonPublicNonStaticProperties(canRead, canWrite), contained, notcontained);

        private void DoProperty_Test(IList<PropertyInfo> props, string[] contained, string[] notcontained)
        {
            Assert.NotNull(props);
            Assert.True(props.Any());

            foreach (var item in contained)
            {
                Assert.True(props.All(x => x.Name.Contains(item)), $"All elements should contain '{item}' in Name ");
            }

            foreach (var item in notcontained)
            {
                Assert.DoesNotContain(props, x => x.Name.Contains(item));
            }
        }
    }
}