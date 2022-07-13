using ITFCodeWA.Extensions.TypeExtendors.Tests.TestData;

namespace ITFCodeWA.Extensions.TypeExtendors.Tests.Classes
{
    public class TestBaseClass
    {
        #region Fields

        private readonly int BaseReadonlyPrivateField = TypeExtensionsTestData.TestClassBase_PrivateField;
        protected readonly int BaseReadonlyProtectedField = TypeExtensionsTestData.TestClassBase_ProtectedField;
        internal readonly int BaseReadonlyInternalField = TypeExtensionsTestData.TestClassBase_InternalField;
        public readonly int BaseReadonlyPublicField = TypeExtensionsTestData.TestClassBase_PublicField;

        private int BasePrivateField = TypeExtensionsTestData.TestClassBase_PrivateField;
        protected int BaseProtectedField = TypeExtensionsTestData.TestClassBase_ProtectedField;
        internal int BaseInternalField = TypeExtensionsTestData.TestClassBase_InternalField;
        public int BasePublicField = TypeExtensionsTestData.TestClassBase_PublicField;

        private static int BaseStaticPrivateField = TypeExtensionsTestData.TestClassBase_PrivateField;
        protected static int BaseStaticProtectedField = TypeExtensionsTestData.TestClassBase_ProtectedField;
        internal static int BaseStaticInternalField = TypeExtensionsTestData.TestClassBase_InternalField;
        public static int BaseStaticPublicField = TypeExtensionsTestData.TestClassBase_PublicField;

        private static readonly int BaseStaticReadonlyPrivateField = TypeExtensionsTestData.TestClassBase_PrivateField;
        protected static readonly int BaseStaticReadonlyProtectedField = TypeExtensionsTestData.TestClassBase_ProtectedField;
        internal static readonly int BaseStaticReadonlyInternalField = TypeExtensionsTestData.TestClassBase_InternalField;
        public static readonly int BaseStaticReadonlyPublicField = TypeExtensionsTestData.TestClassBase_PublicField;

        #endregion

        #region Properties

        private static int BaseStaticPrivateGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_PrivateProp;
        protected static int BaseStaticProtectedGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_ProtectedProp;
        internal static int BaseStaticInternalGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_InternalProp;
        public static int BaseStaticPublicGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_PublicProp;

        private int BasePrivateGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_PrivateProp;
        protected int BaseProtectedGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_ProtectedProp;
        internal int BaseInternalGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_InternalProp;
        public int BasePublicGetSetProp { get; set; } = TypeExtensionsTestData.TestClassBase_PublicProp;

        #endregion
    }
}
