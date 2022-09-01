using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

namespace ITFCodeWA.Core.Domain.Repositories.Base
{
    public partial class Repository<TContext, TEntity, TKey> : ReadOnlyRepository<TContext, TEntity, TKey>,
        IRepository<TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        #region Constructros 

        public Repository([NotNull] TContext context) : base(context) { }

        #endregion

        #region IRepositoryCore Implementation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="RepositoryAddException"></exception>
        public virtual async Task<TEntity> AddAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(entity, nameof(entity));

                var added = (await DbSet.AddAsync(entity, cancellationToken)).Entity;

                if (commit)
                    await CommitChangesAsync(cancellationToken);

                return added;
            }
            catch (Exception ex)
            {
                throw new RepositoryAddException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="DbSetAddRangeException"></exception>
        public virtual async Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateSequence(entities, nameof(entities));

                await DbSet.AddRangeAsync(entities);

                if (commit) await CommitChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new DbSetAddRangeException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updater"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="DbSetUpdateException"></exception>
        public virtual async Task<TEntity> UpdateAsync([NotNull] TKey id, Action<TEntity> updater, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(id, nameof(id));

                ValidateParam(updater, nameof(updater));

                var entity = await GetAsync(id, false, cancellationToken);

                updater(entity);

                return await UpdateAsync(entity, commit, cancellationToken);
            }
            catch (Exception ex)
            {
                throw new DbSetUpdateException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="DbSetUpdateException"></exception>
        public virtual async Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(entity, nameof(entity));

                var updated = DbSet.Update(AttachEntity(entity)).Entity;

                if (commit) await CommitChangesAsync(cancellationToken);

                return updated;
            }
            catch (Exception ex)
            {
                throw new DbSetUpdateException(ex);
            }
        }

        /// <summary>
        /// Updates entities by IDs sequence
        /// </summary>
        /// <param name="ids">sequence of IDs</param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">If ids is empty sequence </exception>
        /// <exception cref="ArgumentException">If ids contains null item</exception>
        /// <exception cref="EntityRangeUpdatingException"></exception>
        public virtual async Task UpdateRangeAsync([NotNull] IEnumerable<TKey> ids, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateSequence(ids, nameof(ids));

                await UpdateRangeAsync(await GetEntitiesByIds(ids), commit, cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityRangeUpdatingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="EntityRangeUpdatingException"></exception>
        public virtual async Task UpdateRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateSequence(entities, nameof(entities));

                DbSet.UpdateRange(AttachEntities(entities));

                if (commit) await CommitChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityRangeUpdatingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="EntityDeletingException"></exception>
        public virtual async Task DeleteAsync([NotNull] TKey id, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(id, nameof(id));

                var entity = await GetAsync(id, false, cancellationToken);

                await DeleteAsync(entity, commit, cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="EntityDeletingException"></exception>
        public virtual async Task DeleteAsync([NotNull] TEntity entity, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateParam(entity, nameof(entity));

                DbSet.Remove(entity);

                if (commit) await CommitChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="EntityDeletingException"></exception>
        public virtual async Task DeleteRangeAsync([NotNull] IEnumerable<TKey> ids, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateSequence(ids, nameof(ids));

                await UpdateRangeAsync(await GetEntitiesByIds(ids), commit, cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="EntityDeletingException"></exception>
        public virtual async Task DeleteRangeAsync([NotNull] IEnumerable<TEntity> entities, bool commit = false, CancellationToken cancellationToken = default)
        {
            try
            {
                ValidateSequence(entities, nameof(entities));

                DbSet.RemoveRange(AttachEntities(entities));

                if (commit) await CommitChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="EntityCommitingException"></exception>
        public virtual async Task<int> CommitChangesAsync([NotNull] CancellationToken cancellationToken = default)
        {
            try
            {
                return await Context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new EntityCommitingException(ex);
            }
        }

        #endregion

        #region Private && Protected 

        /// <summary>
        /// Attaches an entity if entity state is Detached
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Entity</returns>
        protected TEntity AttachEntity(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);

            return entity;
        }

        /// <summary>
        /// Attaches entities of sequence that has state is Detached
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        protected IEnumerable<TEntity> AttachEntities(IEnumerable<TEntity> entities)
        {
            var needed = entities.Where(r => Context.Entry(r).State == EntityState.Detached);

            if (needed.Any())
                DbSet.AttachRange(needed);

            return entities;
        }

        protected IEnumerable<TChildEntity> AttachChildEntities<TChildEntity>(DbSet<TChildEntity> childDbSet, IEnumerable<TChildEntity> entities) where TChildEntity : class 
        {
            var needed = entities.Where(r => Context.Entry(r).State == EntityState.Detached);

            if (needed.Any())
                childDbSet.AttachRange(needed);

            return entities;
        }

        protected virtual void ValidateParam<TParam>(TParam param, string paramName)
        {
            ArgumentNullException.ThrowIfNull(param, paramName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="items"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentException"></exception>
        protected virtual void ValidateSequence<TItem>(IEnumerable<TItem> items, string paramName)
        {
            ValidateParam(items, paramName);

            if (!items.Any())
                throw new ArgumentException($"{paramName} contains no item");

            if (items.Any(x => x is null))
                throw new ArgumentException($"{paramName} contains null item");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        /// <exception cref="EntitiesNotFoundException"></exception>
        protected virtual async Task<IList<TEntity>> GetEntitiesByIds(IEnumerable<TKey> ids)
        {
            ValidateSequence(ids, nameof(ids));

            var list = ids.ToList();

            var entities = await DbSet.Where(x => list.Contains(x.Id)).ToListAsync();

            var excepted = ids.Except(entities.Select(x => x.Id));

            if (excepted.Any())
                throw new EntitiesNotFoundException(excepted.Cast<object>(), typeof(TEntity));

            return entities;
        }

        #endregion

    }
}