namespace ITFCodeWA.Extensions.TypeExtendors.Tests.TestData
{
    internal static partial class TypeExtensionsTestData
    {
        static readonly string[] Field = new string[] { "Field" };
        static readonly string[] Readonly = new string[] { "Readonly" };
        static readonly string[] Static = new string[] { "Static" };
        static readonly string[] Public = new string[] { "Public" };

        static readonly string[] FieldStatic = Field.Concat(Static).ToArray();
        static readonly string[] FieldPublic = Field.Concat(Public).ToArray();
        static readonly string[] FieldReadonly = Field.Concat(Readonly).ToArray();
        static readonly string[] PublicStatic = Public.Concat(Static).ToArray();
        static readonly string[] PublicReadonly = Public.Concat(Readonly).ToArray();

        static readonly string[] StaticReadonly = Static.Concat(Readonly).ToArray();

        static readonly string[] FieldStaticReadonly = FieldStatic.Concat(Readonly).ToArray();
        static readonly string[] FieldPublicStatic = FieldPublic.Concat(Static).ToArray();
        static readonly string[] FieldPublicReadonly = FieldPublic.Concat(Readonly).ToArray();
        static readonly string[] PublicStaticReadonly = PublicStatic.Concat(Readonly).ToArray();

        static readonly string[] FieldPublicStaticReadonly = FieldPublicStatic.Concat(Readonly).ToArray();

        public static IEnumerable<object[]> ForGetStaticFields = new List<object[]>
        {   //  isReadonly, contains(STRING_VALUE), doesNotContain(STRING_VALUE)    
            new object[] { default(bool?), FieldStatic, Array.Empty<string>() },
            new object[] { true, FieldStaticReadonly, Array.Empty<string>() },
            new object[] { false, FieldStatic, Readonly },
        };

        public static IEnumerable<object[]> ForGetStaticPublicFields = new List<object[]>
        {
            new object[] { default(bool?), FieldPublicStatic, Array.Empty<string>() },
            new object[] { true, FieldPublicStaticReadonly, Array.Empty<string>() },
            new object[] { false, FieldPublicStatic , Readonly },
        };

        public static IEnumerable<object[]> ForGetStaticNonPublicFields = new List<object[]>
        {
            new object[] { default(bool?), FieldStatic, Public },
            new object[] { true, FieldStaticReadonly, Public},
            new object[] { false, Field, PublicReadonly },
        };

        public static IEnumerable<object[]> ForGetNonStaticFields = new List<object[]>
        {
            new object[] { default(bool?), Field, Static },
            new object[] { true, FieldReadonly, Static},
            new object[] { false, Field, StaticReadonly },
        };

        public static IEnumerable<object[]> ForGetNonStaticPublicFields = new List<object[]>
        {
            new object[] { default(bool?), Field, Static },
            new object[] { true, FieldPublicReadonly, Static},
            new object[] { false, FieldPublic, StaticReadonly },
        };

        public static IEnumerable<object[]> ForGetNonStaticNonPublicFields = new List<object[]>
        {
            new object[] { default(bool?), Field, PublicStatic },
            new object[] { true, FieldReadonly, PublicStatic},
            new object[] { false, Field, PublicStaticReadonly },
        };

        public static readonly int TestClassBase_PrivateField = GetRandom();
        public static readonly int TestClassBase_ProtectedField = GetRandom();
        public static readonly int TestClassBase_InternalField = GetRandom();
        public static readonly int TestClassBase_PublicField = GetRandom();

        public static readonly int TestClass_StaticPrivateField = GetRandom();
        public static readonly int TestClass_StaticProtectedField = GetRandom();
        public static readonly int TestClass_StaticInternalField = GetRandom();
        public static readonly int TestClass_StaticPublicField = GetRandom();

        public static readonly int TestClass_PrivateField = GetRandom();
        public static readonly int TestClass_ProtectedField = GetRandom();
        public static readonly int TestClass_InternalField = GetRandom();
        public static readonly int TestClass_PublicField = GetRandom();
    }
}