namespace ITFCodeWA.Extensions.TypeExtendors
{
    using System.Reflection;

    public static partial class TypeExtensions
    {
        public const BindingFlags PublicStatic = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

        public const BindingFlags NonPublicStatic = BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy;

        public const BindingFlags PublicNonStatic = BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags NonPublicNonStatic = BindingFlags.NonPublic | BindingFlags.Instance;
    }
}