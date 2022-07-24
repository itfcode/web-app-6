using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class GoodRepository : ReferenceRepository<LifeDataContext, Good>, IGoodRepository
    {
        #region Constructors 

        public GoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion

        #region Private && Protected Methods 

        protected override IQueryable<Good> GetQueryableOneWithDetails()
            => DbSet.Include(x => x.ExpenseItem)
                .Include(x => x.RevenueItem);


        #endregion
    }
}