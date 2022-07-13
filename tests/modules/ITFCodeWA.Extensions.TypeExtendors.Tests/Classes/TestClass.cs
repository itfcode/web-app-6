using ITFCodeWA.Extensions.TypeExtendors.Tests.TestData;

namespace ITFCodeWA.Extensions.TypeExtendors.Tests.Classes
{
    public class TestClass : TestBaseClass
    {
        #region Fields

        private const int ConstPrivateField = int.MinValue + 10;
        protected const int ConstProtectedField = int.MaxValue - 10;
        internal const int ConstInternalField = int.MaxValue - 100;
        public const int ConstPublicField = int.MaxValue - 1000;

        private readonly int ReadonlyPrivateField = TypeExtensionsTestData.TestClass_PrivateField;
        protected readonly int ReadonlyProtectedField = TypeExtensionsTestData.TestClass_ProtectedField;
        internal readonly int ReadonlyInternalField = TypeExtensionsTestData.TestClass_InternalField;
        public readonly int ReadonlyPublicField = TypeExtensionsTestData.TestClass_PublicField;

        private int PrivateField = TypeExtensionsTestData.TestClass_PrivateField;
        protected int ProtectedField = TypeExtensionsTestData.TestClass_ProtectedField;
        internal int InternalField = TypeExtensionsTestData.TestClass_InternalField;
        public int PublicField = TypeExtensionsTestData.TestClass_PublicField;

        private static int StaticPrivateField = TypeExtensionsTestData.TestClass_PrivateField;
        protected static int StaticProtectedField = TypeExtensionsTestData.TestClass_ProtectedField;
        internal static int StaticInternalField = TypeExtensionsTestData.TestClass_InternalField;
        public static int StaticPublicField = TypeExtensionsTestData.TestClass_PublicField;

        private static readonly int StaticReadonlyPrivateField = TypeExtensionsTestData.TestClass_PrivateField;
        protected static readonly int StaticReadonlyProtectedField = TypeExtensionsTestData.TestClass_ProtectedField;
        internal static readonly int StaticReadonlyInternalField = TypeExtensionsTestData.TestClass_InternalField;
        public static readonly int StaticReadonlyPublicField = TypeExtensionsTestData.TestClass_PublicField;

        #endregion

        #region Properties

        private static int StaticPrivateGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_StaticPrivateProp;
        protected static int StaticProtectedGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_StaticProtectedProp;
        internal static int StaticInternalGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_StaticInternalProp;
        public static int StaticPublicGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_StaticPublicProp;

        private int PrivateGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_StaticPrivateProp;
        protected int ProtectedGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_ProtectedProp;
        internal int InternalGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_InternalProp;
        public int PublicGetSetProp { get; set; } = TypeExtensionsTestData.TestClass_PublicProp;

        private int PrivateGetProp { get; } = TypeExtensionsTestData.TestClass_StaticPrivateProp;
        protected int ProtectedGetProp { get; } = TypeExtensionsTestData.TestClass_ProtectedProp;
        internal int InternalGetProp { get; } = TypeExtensionsTestData.TestClass_InternalProp;
        public int PublicGetProp { get; } = TypeExtensionsTestData.TestClass_PublicProp;

        private int PrivateSetProp { set { var s = value; } }
        protected int ProtectedSetProp { set { var s = value; } }
        internal int InternalSetProp { set { var s = value; } }
        public int PublicSetProp { set { var s = value; } }

        private static int StaticPrivateGetProp { get; } = TypeExtensionsTestData.TestClass_StaticPrivateProp;
        protected static int StaticProtectedGetProp { get; } = TypeExtensionsTestData.TestClass_ProtectedProp;
        internal static int StaticInternalGetProp { get; } = TypeExtensionsTestData.TestClass_InternalProp;
        public static int StaticPublicGetProp { get; } = TypeExtensionsTestData.TestClass_PublicProp;

        private static int StaticPrivateSetProp { set { var s = value; } }
        protected static int StaticProtectedSetProp { set { var s = value; } }
        internal static int StaticInternalSetProp { set { var s = value; } }
        public static int StaticPublicSetProp { set { var s = value; } }

        #endregion

    }
}
