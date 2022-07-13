namespace ITFCodeWA.Extensions.TypeExtendors.Tests.TestData
{
    internal static partial class TypeExtensionsTestData
    {
        private static int GetRandom() => new Random().Next();

        private static T[] GetArray<T>(params T[] values) => values; 
    }
}