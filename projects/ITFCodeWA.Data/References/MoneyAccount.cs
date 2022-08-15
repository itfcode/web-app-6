using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Money Accounts;  RU: Денежные счета
    /// </summary>
    public class MoneyAccount : ReferenceBase
    {
        /// <summary>
        /// Id of Currency 
        /// </summary>
        public int? CurrencyId { get; set; }

        /// <summary>
        /// EN: Account Currency; RU: Валюта счета
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Id of Account Owner
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// EN: Account Owner, RU: Владелец счета
        /// </summary>
        public Person Person { get; set; }
    }
}