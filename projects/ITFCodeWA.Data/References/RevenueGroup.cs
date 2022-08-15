using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Revenue Item; RU: Статья Доходов 
    /// </summary>
    public class RevenueGroup : ReferenceBase
    {
        public virtual ICollection<RevenueItem> RevenueItems { get; set; }
    }
}
