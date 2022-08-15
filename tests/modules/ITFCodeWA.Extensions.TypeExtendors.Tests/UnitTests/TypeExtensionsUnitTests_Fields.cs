namespace ITFCodeWA.Extensions.TypeExtendors.Tests.UnitTests
{
    using ITFCodeWA.Extensions.TypeExtendors.Tests.TestData;
    using System.Reflection;

    public partial class TypeExtensionsUnitTests
    {
        public static IEnumerable<object[]> GetStaticFields_Data => TypeExtensionsTestData.ForGetStaticFields;
        public static IEnumerable<object[]> GetPublicStaticFields_Data => TypeExtensionsTestData.ForGetStaticPublicFields;
        public static IEnumerable<object[]> GetNonPublicStaticFields_Data => TypeExtensionsTestData.ForGetStaticNonPublicFields;

        public static IEnumerable<object[]> GetNonStaticFields_Data => TypeExtensionsTestData.ForGetNonStaticFields;
        public static IEnumerable<object[]> GetPublicNonStaticFields_Data => TypeExtensionsTestData.ForGetNonStaticPublicFields;
        public static IEnumerable<object[]> GetNonPublicNonStaticFields_Data => TypeExtensionsTestData.ForGetNonStaticNonPublicFields;

        [Theory]
        [MemberData(nameof(GetStaticFields_Data))]
        public void GetStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetStaticFields(isReadonly), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetPublicStaticFields_Data))]
        public void GetPublicStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetPublicStaticFields(isReadonly), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonPublicStaticFields_Data))]
        public void GetNonPublicStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetNonPublicStaticFields(isReadonly), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonStaticFields_Data))]
        public void GetNonStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetNonStaticFields(isReadonly), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetPublicNonStaticFields_Data))]
        public void GetPublicNonStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetPublicNonStaticFields(isReadonly), contained, notcontained);

        [Theory]
        [MemberData(nameof(GetNonPublicNonStaticFields_Data))]
        public void GetNonPublicNonStaticFields_Test(bool? isReadonly, string[] contained, string[] notcontained)
            => DoField_Test(_type.GetNonPublicNonStaticFields(isReadonly), contained, notcontained);

        private void DoField_Test(IList<FieldInfo> fields, string[] contained, string[] notcontained)
        {
            Assert.NotNull(fields);
            Assert.True(fields.Any());

            foreach (var item in contained)
            {
                Assert.True(fields.All(x => x.Name.Contains(item)), $"All elements should contain '{item}' in Name ");
            }

            foreach (var item in notcontained)
            {
                Assert.DoesNotContain(fields, x => x.Name.Contains(item));
            }
        }
    }
}