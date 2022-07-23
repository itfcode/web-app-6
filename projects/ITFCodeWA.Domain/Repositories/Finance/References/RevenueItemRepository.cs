using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.Finance.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Finance.References.Intrefaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Finance.References
{
    public class RevenueItemRepository : ReferenceRepository<LifeDataContext, RevenueItem>, IRevenueItemRepository
    {
        #region Constructors 

        public RevenueItemRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}