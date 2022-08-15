using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class GoodRepository : ReferenceRepository<LifeDataContext, Good>, IGoodRepository
    {
        #region Constructors 

        public GoodRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion

        #region Private && Protected Methods 

        protected override IQueryable<Good> GetOneWithDetails()
            => DbSet.Include(x => x.ExpenseItem)
                .Include(x => x.RevenueItem);

        protected override IQueryable<Good> GetManyWithDetails()
            => DbSet.Include(x => x.ExpenseItem)
                .Include(x => x.RevenueItem);

        #endregion
    }
}