using ITFCodeWA.Core.Domain.Repositories.References;
using ITFCodeWA.Data.References;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.References.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.References
{
    public class RevenueGroupRepository : ReferenceRepository<LifeDataContext, RevenueGroup>, IRevenueGroupRepository
    {
        #region Constructors 

        public RevenueGroupRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion
    }
}