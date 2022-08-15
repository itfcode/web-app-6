using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Revenue Item; RU: Статья Доходов 
    /// </summary>
    public class RevenueItem : ReferenceBase
    {
        public int RevenueGroupId { get; set; }

        public RevenueGroup RevenueGroup { get; set; }

        public virtual ICollection<Good> Goods { get; set; }
    }
}
