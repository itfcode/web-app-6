using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

namespace ITFCodeWA.Core.Domain.Repositories
{
    public partial class RepositoryCore<TContext, TEntity, TKey> : ReadOnlyRepositoryCore<TContext, TEntity, TKey>,
        IRepositoryCore<TContext, TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        #region Constructros 

        public RepositoryCore([NotNull] TContext context) : base(context) { }

        #endregion

        #region IRepositoryCore Implementation

        public async Task<TEntity> AddAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellation = default)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

                var added = (await DbSet.AddAsync(entity, cancellation)).Entity;

                if (autoSave)
                    await SaveChangesAsync(cancellation);

                return added;
            }
            catch (Exception ex)
            {
                throw new EntityAddingException(ex);
            }
        }

        public async Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entities, nameof(entities));

                if (entities.Any(x => x is null))
                    ArgumentNullException.ThrowIfNull(entities, $"{nameof(entities)} contains null item");

                await DbSet.AddRangeAsync(entities);

                if (autoSave) await SaveChangesAsync(cancellation);
            }
            catch (Exception ex)
            {
                throw new EntityRangeAddingException(ex);
            }
        }

        public async Task<TEntity> UpdateAsync([NotNull] TKey id, Action<TEntity> updater, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(id, nameof(id));

                var entity = await GetAsync(id, false, cancellationToken);

                updater(entity);

                return await UpdateAsync(entity, autoSave, cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityUpdatingException(ex);
            }
        }

        public async Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

                AttachEntity(entity);

                var updated = DbSet.Update(entity).Entity;

                if (autoSave) await SaveChangesAsync(cancellationToken);

                return updated;
            }
            catch (Exception ex)
            {
                throw new EntityUpdatingException(ex);
            }
        }

        public async Task UpdateRangeAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync([NotNull] TKey id, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRangeAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRangeAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangesAsync([NotNull] CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}