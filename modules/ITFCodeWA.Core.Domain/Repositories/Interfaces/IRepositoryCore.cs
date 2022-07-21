using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Core.Domain.Repositories.Interfaces
{
    public interface IRepositoryCore<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        bool Exist(TKey id);
        TEntity GetById(TKey id);
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
        TEntity Update(TKey id, Action<TEntity> updater);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> UpdateRange(IEnumerable<TKey> ids);
        IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TKey id);
        void Delete(TEntity entity) => throw new NotImplementedException();
        void DeleteRange(IEnumerable<TKey> ids);
        void DeleteRange(IEnumerable<TEntity> entities);
        int SaveChanges();

        Task<bool> ExistAsync(TKey id, CancellationToken cancellation = default);
        Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellation = default);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
        Task<TEntity> UpdateAsync(TKey id, Action<TEntity> updater, CancellationToken cancellation = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellation = default);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellation = default);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
        Task DeleteAsync(TKey id, CancellationToken cancellation = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellation = default);
        Task DeleteRangeAsync(IEnumerable<TKey> ids, CancellationToken cancellation = default);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
