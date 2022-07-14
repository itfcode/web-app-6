using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Finance.References
{
    /// <summary>
    /// EN: Expense Item; RU: Статья Расходов 
    /// </summary>
    public class ExpenseItem : ReferenceBase
    {
        public virtual ICollection<Good>? Goods { get; set; }
    }
}
