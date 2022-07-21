using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

namespace ITFCodeWA.Core.Domain.Repositories
{
    public abstract class RepositoryCore<TContext, TEntity, TKey> : IRepositoryCore<TContext, TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        #region Private & Protected Fields 

        private readonly TContext _context;

        private readonly DbSet<TEntity> _dbSet;

        #endregion

        #region Protected 

        protected TContext Context => _context;

        protected DbSet<TEntity> DbSet => _dbSet;

        #endregion

        #region Constructros 

        public RepositoryCore(TContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        #endregion

        #region Sync Methods 

        public virtual bool Exist(TKey id)
        {
            ArgumentNullException.ThrowIfNull(id, nameof(id));

            return DbSet.Any(GenerateEqual<TEntity>("Id", id));
        }

        public virtual TEntity GetById(TKey id)
        {
            ArgumentNullException.ThrowIfNull(id, nameof(id));

            return DbSet.Find(id);
        }

        public virtual TEntity Add(TEntity entity)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

                return DbSet.Add(entity).Entity;
            }
            catch (Exception ex)
            {
                throw new EntityAddingException(ex.Message, ex);
            }
        }

        public virtual void AddRange(IEnumerable<TEntity> entities) 
        {
            try
            {
                DbSet.AddRange(entities);
            }
            catch (Exception ex)
            {
                throw new EntityAddingException(ex.Message, ex);
            }
        }

        public virtual TEntity Update(TKey id, Action<TEntity> updater) => throw new NotImplementedException();

        public virtual TEntity Update(TEntity entity) => throw new NotImplementedException();

        public virtual void UpdateRange(IEnumerable<TKey> ids) => throw new NotImplementedException();

        public virtual void UpdateRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();

        public virtual void Delete(TKey id)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(id, nameof(id));

                var entity = GetById(id) ?? throw new NullReferenceException($"Entity '{typeof(TEntity).Name}' with id = {id} not found");

                Delete(entity);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex.Message, ex);
            }
        }

        public virtual void Delete(TEntity entity)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

                AttachEntity(entity);

                DbSet.Remove(entity);
            }
            catch (Exception ex)
            {
                throw new EntityDeletingException(ex.Message, ex);
            }
        }

        public virtual void DeleteRange(IEnumerable<TKey> ids)
        {

        }

        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            ArgumentNullException.ThrowIfNull(entities, nameof(entities));

            AttachEntities(entities);

            DbSet.RemoveRange(entities);
        }

        public virtual int SaveChanges() => throw new NotImplementedException();

        #endregion

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

        #region Private Methods 

        protected void AttachEntity(TEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);
        }

        protected void AttachEntities(IEnumerable<TEntity> entities)
        {
            var needed = entities.Where(r => Context.Entry(r).State == EntityState.Detached);

            if (needed.Any())
                DbSet.AttachRange(needed);
        }

        #endregion
    }

}
