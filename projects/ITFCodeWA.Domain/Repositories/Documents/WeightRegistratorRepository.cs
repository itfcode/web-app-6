using ITFCodeWA.Core.Domain.Repositories.Documents;
using ITFCodeWA.Data.Documents;
using ITFCodeWA.Domain.DataContext;
using ITFCodeWA.Domain.Repositories.Documents.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Domain.Repositories.Documents
{
    public class WeightRegistratorRepository : DocumentRepository<LifeDataContext, WeightRegistrator>, IWeightRegistratorRepository
    {
        #region Constructors 

        public WeightRegistratorRepository([NotNull] LifeDataContext context) : base(context) { }

        #endregion

        #region Private & Protected Properties 

        protected override IQueryable<WeightRegistrator> GetOneWithDetails()
            => DbSet.Include(x => x.Rows);

        #endregion
    }
}