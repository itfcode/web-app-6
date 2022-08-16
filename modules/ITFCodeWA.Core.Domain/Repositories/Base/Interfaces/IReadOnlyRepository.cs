using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Repositories.Base.Interfaces
{
    public interface IReadOnlyRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        Task<bool> ExistsAsync([NotNull] TKey id, CancellationToken cancellationToken = default);

        Task<bool> ExistsAsync([NotNull] Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        Task<TEntity> FindAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> FindAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> GetAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> GetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

        IQueryable<TEntity> GetDBSetQuery(bool includeDetails = false);
    }
}
