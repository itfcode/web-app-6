namespace ITFCodeWA.Extensions.TypeExtendors
{
    using System.Reflection;

    public static partial class TypeExtensions
    {
        public static IList<PropertyInfo> GetStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, new BindingFlags[] { PublicStatic, NonPublicStatic }, canRead, canWrite);

        public static IList<PropertyInfo> GetPublicStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, PublicStatic, canRead, canWrite);

        public static IList<PropertyInfo> GetNonPublicStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, NonPublicStatic, canRead, canWrite);

        public static IList<PropertyInfo> GetNonStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, new BindingFlags[] { PublicNonStatic, NonPublicNonStatic }, canRead, canWrite);

        public static IList<PropertyInfo> GetPublicNonStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, PublicNonStatic, canRead, canWrite);

        public static IList<PropertyInfo> GetNonPublicNonStaticProperties(this Type self, bool? canRead = default, bool? canWrite = default)
            => GetProperties(self, NonPublicNonStatic, canRead, canWrite);

        private static IList<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlag, bool? canRead = default, bool? canWrite = default)
        {
            ArgumentNullException.ThrowIfNull(type, nameof(type));

            return type.GetProperties(bindingFlag)
                .Where(x => !canRead.HasValue || x.CanRead == canRead)
                .Where(x => !canWrite.HasValue || x.CanWrite == canWrite)
                .OrderBy(x => x.Name)
                .ToList();
        }

        private static IList<PropertyInfo> GetProperties(Type type, BindingFlags[] bindingFlags, bool? canRead = default, bool? canWrite = default)
        {
            ArgumentNullException.ThrowIfNull(type, nameof(type));
            ArgumentNullException.ThrowIfNull(bindingFlags, nameof(bindingFlags));

            if (bindingFlags.Length == 0)
                throw new ArgumentException($"{bindingFlags} should be not empty collection!!!");

            List<PropertyInfo> result = new();

            foreach (var flag in bindingFlags)
            {
                result.AddRange(GetProperties(type, flag, canRead, canWrite));
            }

            return result.OrderBy(x => x.Name).ToList();
        }
    }
}