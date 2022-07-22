using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.Interfaces
{
    public interface IRepositoryCore<TContext, TEntity, TKey> : IReadOnlyRepositoryCore<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        Task<TEntity> AddAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellation = default);
        Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default);

        Task<TEntity> UpdateAsync([NotNull] TKey id, Action<TEntity> updater, bool autoSave = false, CancellationToken cancellation = default);
        Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellation = default);

        Task UpdateRangeAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellation = default);
        Task UpdateRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default);

        Task DeleteAsync([NotNull] TKey id, bool autoSave = false, CancellationToken cancellation = default);
        Task DeleteAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellation = default);

        Task DeleteRangeAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellation = default);
        Task DeleteRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default);

        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
