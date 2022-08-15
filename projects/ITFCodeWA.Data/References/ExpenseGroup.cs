using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Expense Item; RU: Статья Расходов 
    /// </summary>
    public class ExpenseItem : ReferenceBase
    {
        public int ExpenseGroupId { get; set; }

        public ExpenseGroup ExpenseGroup { get; set; }

        public virtual ICollection<Good>? Goods { get; set; }
    }
}
