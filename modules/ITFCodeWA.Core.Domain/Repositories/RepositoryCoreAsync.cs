using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

namespace ITFCodeWA.Core.Domain.Repositories
{
    public abstract partial class RepositoryCore<TContext, TEntity, TKey> : IRepositoryCore<TContext, TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        #region Async Methods 

        public virtual async Task<bool> ExistAsync(TKey id, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task<TEntity> UpdateAsync(TKey id, Action<TEntity> updater, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task UpdateRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellation = default) =>
            throw new NotImplementedException();

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task DeleteAsync(TKey id, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task DeleteRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default)
            => throw new NotImplementedException();

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellation = default)
            => throw new NotImplementedException();

        #endregion
    }
}
