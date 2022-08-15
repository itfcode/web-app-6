using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Expense Item; RU: Статья Расходов 
    /// </summary>
    public class ExpenseGroup : ReferenceBase
    {
        public virtual ICollection<ExpenseItem>? ExpenseItems { get; set; }
    }
}
