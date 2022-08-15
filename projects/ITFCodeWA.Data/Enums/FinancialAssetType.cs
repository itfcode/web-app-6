using System.ComponentModel;

namespace ITFCodeWA.Data.Enums
{
    /// <summary>
    /// Вида финансовых активов
    /// </summary>
    public enum FinancialAssetType
    {
        [Description("Наличные")]
        Cash = 10,

        [Description("Драгоценные металлы")]
        PreciousMetal = 20,

        [Description("Облигации")]
        Bond = 30,

        [Description("Акции")]
        Stock = 40,

        [Description("Банковский депозит")]
        BankDeposit = 50,

        [Description("Страховой полис")]
        InsurancePolicy = 100,
    }
}
