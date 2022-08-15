using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class RevenueItemRepository : ReferenceRepository<LifeDataContext, RevenueItem>, IRevenueItemRepository
    {
        #region Constructors 

        public RevenueItemRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}