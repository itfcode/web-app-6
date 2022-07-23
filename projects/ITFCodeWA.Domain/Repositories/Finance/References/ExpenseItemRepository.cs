using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class ExpenseItemRepository : ReferenceRepository<LifeDataContext, ExpenseItem>, IExpenseItemRepository
    {
        #region Constructors 

        public ExpenseItemRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}