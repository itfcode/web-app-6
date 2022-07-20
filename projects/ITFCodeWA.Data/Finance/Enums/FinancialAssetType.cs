using System.ComponentModel;

namespace ITFCodeWA.Data.Finance.Enums
{
    /// <summary>
    /// Вида финансовых активов
    /// </summary>
    public enum FinancialAssetType
    {
        [Description("Наличные")]
        Cash = 10,

        [Description("Страховой полис")]
        InsurancePolicy = 100,
    }
}
