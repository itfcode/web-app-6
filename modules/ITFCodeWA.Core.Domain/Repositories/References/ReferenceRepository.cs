using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Base;
using ITFCodeWA.Core.Domain.Repositories.References.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.References
{
    public class ReferenceRepository<TContext, TEntity> : Repository<TContext, TEntity, int>,
            IReferenceRepository<TContext, TEntity>
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
            => await FindByNameAsync(name, includeDetails, cancellationToken) ?? throw new EntityNotFoundException(name, "Name", typeof(TEntity));

        public virtual async Task<TEntity> GetAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => throw new NotImplementedException();

        public virtual async Task<TEntity> FindAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default)
            => throw new NotImplementedException();

        #endregion
    }
}