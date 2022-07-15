using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Finance.References
{
    /// <summary>
    /// EN: Revenue Item; RU: Статья Доходов 
    /// </summary>
    public class RevenueItem : ReferenceBase
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Good> Goods { get; set; }
    }
}
