using System.Reflection;

namespace ITFCodeWA.Extensions.TypeExtendors
{
    public static partial class TypeExtensions
    {
        public static IList<FieldInfo> GetStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, new BindingFlags[] { PublicStatic, NonPublicStatic }, isReadonly);

        public static IList<FieldInfo> GetPublicStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, PublicStatic, isReadonly);

        public static IList<FieldInfo> GetNonPublicStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, NonPublicStatic, isReadonly);

        public static IList<FieldInfo> GetNonStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, new BindingFlags[] { PublicNonStatic, NonPublicNonStatic }, isReadonly);

        public static IList<FieldInfo> GetPublicNonStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, PublicNonStatic, isReadonly);

        public static IList<FieldInfo> GetNonPublicNonStaticFields(this Type self, bool? isReadonly = default)
            => GetFields(self, NonPublicNonStatic, isReadonly);

        private static IList<FieldInfo> GetFields(Type type, BindingFlags bindingFlag, bool? isReadonly = default)
        {
            ArgumentNullException.ThrowIfNull(type, nameof(type));

            return type.GetFields(bindingFlag)
                .Where(x => !isReadonly.HasValue || x.IsInitOnly == isReadonly)
                .Where(x => !x.IsLiteral)
                .Where(x => !x.Name.ToLower().Contains("BackingField".ToLower()))
                .OrderBy(x => x.Name)
                .ToList();
        }

        private static IList<FieldInfo> GetFields(Type type, BindingFlags[] bindingFlags, bool? isReadonly = default)
        {
            ArgumentNullException.ThrowIfNull(type, nameof(type));
            ArgumentNullException.ThrowIfNull(bindingFlags, nameof(bindingFlags));

            if (bindingFlags.Length == 0)
                throw new ArgumentException($"{bindingFlags} should be not empty collection!!!");

            List<FieldInfo> result = new();

            foreach (var flag in bindingFlags)
                result.AddRange(GetFields(type, flag, isReadonly));

            return result.OrderBy(x => x.Name).ToList();
        }
    }
}
