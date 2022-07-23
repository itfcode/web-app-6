using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.References.Interfaces
{
    public interface IReadOnlyReferenceRepository<TContext, TEntity> : IReadOnlyRepository<TContext, TEntity, int>
        where TContext : DbContext
        where TEntity : class, IReference
    {
        Task<TEntity> GetByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
        Task<TEntity> FindByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> GetAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
        Task<TEntity> FindAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
    }
}