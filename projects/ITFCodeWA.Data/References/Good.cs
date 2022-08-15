using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// EN: Goods and Services;  RU: Товары и услуги
    /// </summary>
    public class Good : ReferenceBase
    {
        public int? RevenueItemId { get; set; }

        public int? ExpenseItemId { get; set; }

        public int GoodGroupId { get; set; }

        /// <summary>
        /// EN: Good Group; RU: Группа товаров / услуг; 
        /// </summary>
        public GoodGroup GoodGroup { get; set; }

        /// <summary>
        /// EN: Revenue Item by deafult; RU: Статья Доходов по умолчанию; 
        /// </summary>
        public RevenueItem? RevenueItem { get; set; } 

        /// <summary>
        /// EN: Expense Item by deafult; RU: Статья Расходов по умолчанию 
        /// </summary>
        public ExpenseItem? ExpenseItem { get; set; }
    }

}
