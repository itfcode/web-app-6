using ITFCodeWA.Core.Data.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Data.Finance.References
{
    /// <summary>
    /// EN: Goods and Services;  RU: Товары и услуги
    /// </summary>
    public class Good : ReferenceBase
    {
        /// <summary>
        /// Id of Revenue Item by deafult 
        /// </summary>
        public int? RevenueItemId { get; set; }

        /// <summary>
        /// Id of Expense Item by deafult
        /// </summary>
        public int? ExpenseItemId { get; set; }

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
