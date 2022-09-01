using ITFCodeWA.Core.Domain.Exceptions;
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

        public override async Task<WeightRegistrator> UpdateAsync([NotNull] WeightRegistrator entity, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(entity, nameof(entity));

                var dbSetRows = Context.Set<WeightRegistratorRow>();

                dbSetRows.UpdateRange(AttachChildEntities(dbSetRows, entity.Rows));

                var updated = DbSet.Update(AttachEntity(entity)).Entity;

                if (commit) await CommitChangesAsync(cancellationToken);

                return updated;
            }
            catch (Exception ex)
            {
                throw new DbSetUpdateException(ex);
            }
        }


        protected override IQueryable<WeightRegistrator> GetOneWithDetails()
            => DbSet
                .Include(x => x.Person)
                .Include(x => x.Rows);

        protected override IQueryable<WeightRegistrator> GetManyWithDetails()
            => DbSet
                .Include(x => x.Person)
                .Include(x => x.Rows);

        #endregion
    }
}