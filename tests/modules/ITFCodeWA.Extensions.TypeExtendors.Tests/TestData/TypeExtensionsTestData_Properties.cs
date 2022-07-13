namespace ITFCodeWA.Extensions.TypeExtendors.Tests.TestData
{
    internal static partial class TypeExtensionsTestData
    {
        public static IEnumerable<object[]> ForGetStaticProperties = new List<object[]>
        {   //  canRead, canWrite, contains(STRING_VALUE), doesNotContain(STRING_VALUE)    
            new object[] { default(bool?), default(bool?), new string[] {"Prop", "Static"}, new string[] { } },
            new object[] { true, default(bool?), new string[] {"Prop", "Static", "Get" }, new string[] { } },
            new object[] { true, false, new string[] {"Prop", "Static", "Get" }, new string[] { "Set" } },
            new object[] { default(bool?), true, new string[] {"Prop", "Static", "Set" }, new string[] { } },
            new object[] { false, true, new string[] { "Prop", "Static", "Set" }, new string[] { "Get" } },
        };

        public static IEnumerable<object[]> ForGetStaticPublicProperties = new List<object[]>
        {
            new object[] { default(bool?), default(bool?), new string[] {"Prop", "Static", "Public" }, new string[] { "Internal", "Private", "Protected" } },
            new object[] { true, default(bool?), new string[] {"Prop", "Static", "Public", "Get" }, new string[] { "Internal", "Private", "Protected" } },
            new object[] { true, false, new string[] { "Prop", "Static", "Public", "Get" }, new string[] { "Set", "Internal", "Private", "Protected" } },
            new object[] { default(bool?), true, new string[] { "Prop", "Static", "Public", "Set" }, new string[] { "Internal", "Private", "Protected"} },
            new object[] { false, true, new string[] { "Prop", "Static", "Public", "Set" }, new string[] { "Get", "Internal", "Private", "Protected"} },
        };

        public static IEnumerable<object[]> ForGetStaticNonPublicProperties = new List<object[]>
        {
            new object[] { default(bool?), default(bool?), new string[] { "Prop", "Static" }, new string[] { "Public" } },
            new object[] { true, default(bool?), new string[] { "Prop", "Static", "Get" }, new string[] { "Public" } },
            new object[] { true, false, new string[] { "Prop", "Static", "Get" }, new string[] { "Set", "Public" } },
            new object[] { default(bool?), true, new string[] { "Prop", "Static", "Set" }, new string[] { "Public" } },
            new object[] { false, true, new string[] { "Prop", "Static", "Set" }, new string[] { "Get", "Public" } },
        };

        public static IEnumerable<object[]> ForGetNonStaticProperties = new List<object[]>
        {   //  canRead, canWrite, contains(STRING_VALUE), doesNotContain(STRING_VALUE)    
            new object[] { default(bool?), default(bool?), new string[] { "Prop" }, new string[] { "Static" } },
            new object[] { true, default(bool?), new string[] { "Prop", "Get" }, new string[] { "Static" } },
            new object[] { true, false, new string[] { "Get" }, new string[] { "Set", "Static" } },
            new object[] { default(bool?), true, new string[] { "Set" }, new string[] { "Static" } },
            new object[] { false, true, new string[] { "Set" }, new string[] { "Get", "Static" } },
        };

        public static IEnumerable<object[]> ForGetNonStaticPublicProperties = new List<object[]>
        {
            new object[] { default(bool?), default(bool?), new string[] {"Public" }, new string[] { "Static", "Internal", "Private", "Protected" } },
            new object[] { true, default(bool?), new string[] { "Public", "Get" }, new string[] { "Static", "Internal", "Private", "Protected" } },
            new object[] { true, false, new string[] { "Public", "Get" }, new string[] { "Static", "Set", "Internal", "Private", "Protected" } },
            new object[] { default(bool?), true, new string[] { "Public", "Set" }, new string[] { "Static", "Internal", "Private", "Protected"} },
            new object[] { false, true, new string[] { "Public", "Set" }, new string[] { "Static", "Get", "Internal", "Private", "Protected"} },
        };

        public static IEnumerable<object[]> ForGetNonStaticNonPublicProperties = new List<object[]>
        {
            new object[] { default(bool?), default(bool?), new string[] { "Prop" }, new string[] { "Public", "Static" } },
            new object[] { true, default(bool?), new string[] { "Prop", "Get" }, new string[] { "Public", "Static" } },
            new object[] { true, false, new string[] { "Prop", "Get" }, new string[] { "Set", "Public", "Static" } },
            new object[] { default(bool?), true, new string[] { "Prop", "Set" }, new string[] { "Public", "Static" } },
            new object[] { false, true, new string[] { "Prop", "Set" }, new string[] { "Get", "Public", "Static" } },
        };

        public static readonly int TestClassBase_PrivateProp = GetRandom();
        public static readonly int TestClassBase_ProtectedProp = GetRandom();
        public static readonly int TestClassBase_InternalProp = GetRandom();
        public static readonly int TestClassBase_PublicProp = GetRandom();

        public static readonly int TestClass_StaticPrivateProp = GetRandom();
        public static readonly int TestClass_StaticProtectedProp = GetRandom();
        public static readonly int TestClass_StaticInternalProp = GetRandom();
        public static readonly int TestClass_StaticPublicProp = GetRandom();

        public static readonly int TestClass_PrivateProp = GetRandom();
        public static readonly int TestClass_ProtectedProp = GetRandom();
        public static readonly int TestClass_InternalProp = GetRandom();
        public static readonly int TestClass_PublicProp = GetRandom();
    }
}