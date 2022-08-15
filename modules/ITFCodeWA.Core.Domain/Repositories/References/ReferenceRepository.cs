using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base;
using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.References
{
    public class ReferenceRepository<TContext, TEntity> : Repository<TContext, TEntity, int>,
            IReferenceRepository<TEntity>
        where TContext : DbContext
        where TEntity : class, IReference
    {
        #region Constructors 

        public ReferenceRepository([NotNull] TContext context) : base(context) { }

        #endregion

        #region IReferenceRepository Implementation

        public virtual async Task<TEntity> FindByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(x => x.Name == name, includeDetails, cancellationToken);

        public virtual async Task<TEntity> GetByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => ValidateFindRequest(await FindByNameAsync(name, includeDetails, cancellationToken), name, "Name");

        public virtual async Task<IList<TEntity>> FindAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await GetQueryableForMany(includeDetails).Where(x => x.Name.Contains(name)).ToListAsync(cancellationToken);

        public virtual async Task<IList<TEntity>> GetAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => ValidateFindAllRequest(await FindAllByNameAsync(name, includeDetails, cancellationToken), name, "Name");

        #endregion
    }
}