using ITFCodeWA.Extensions.TypeExtendors.Tests.TestData;

namespace ITFCodeWA.Extensions.TypeExtendors.Tests.Classes
{
    public class TestBaseClass
    {
        #region Fields

        private readonly int BasePrivateField = TypeExtensionsTestData.TestClassBase_PrivateField;
        protected readonly int BaseProtectedField = TypeExtensionsTestData.TestClassBase_ProtectedField;
        internal readonly int BaseInternalField = TypeExtensionsTestData.TestClassBase_InternalField;
        public readonly int BasePublicField = TypeExtensionsTestData.TestClassBase_PublicField;

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
