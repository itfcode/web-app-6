using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.Base.Interfaces
{
    public interface IRepository<TEntity, TKey> : IReadOnlyRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        Task<TEntity> AddAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellation = default);
        Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellation = default);

        Task<TEntity> UpdateAsync([NotNull] TKey id, Action<TEntity> updater, bool commit = false, CancellationToken cancellation = default);
        Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellation = default);

        Task UpdateRangeAsync([NotNull] IEnumerable<TKey> ids, bool commit = false, CancellationToken cancellation = default);
        Task UpdateRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellation = default);

        Task DeleteAsync([NotNull] TKey id, bool commit = false, CancellationToken cancellation = default);
        Task DeleteAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellation = default);

        Task DeleteRangeAsync([NotNull] IEnumerable<TKey> ids, bool commit = false, CancellationToken cancellation = default);
        Task DeleteRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellation = default);

        Task<int> CommitChangesAsync(CancellationToken cancellation = default);
    }
}
