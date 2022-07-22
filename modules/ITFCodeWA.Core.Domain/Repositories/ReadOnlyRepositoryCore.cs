using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

namespace ITFCodeWA.Core.Domain.Repositories
{
    public partial class ReadOnlyRepositoryCore<TContext, TEntity, TKey> : IReadOnlyRepositoryCore<TContext, TEntity, TKey>
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

        public ReadOnlyRepositoryCore([NotNull] TContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        #endregion

        #region IReadOnlyRepositoryCore implementation

        public async Task<bool> ExistsAsync([NotNull] TKey id, CancellationToken cancellationToken = default)
            => await ExistsAsync(GenerateEqual<TEntity>("Id", id), cancellationToken);

        public async Task<bool> ExistsAsync([NotNull] Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
            => await GetQueryable().AnyAsync(predicate, cancellationToken);

        public virtual async Task<TEntity> FindAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await GetQueryable(includeDetails).SingleOrDefaultAsync(predicate, cancellationToken);

        public virtual async Task<TEntity> FindAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(GenerateEqual<TEntity>("Id", id), includeDetails, cancellationToken);

        public virtual async Task<TEntity> GetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(predicate, includeDetails, cancellationToken) ?? throw new EntityNotFoundException(typeof(TEntity));

        public virtual async Task<TEntity> GetAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(id, includeDetails, cancellationToken) ?? throw new EntityNotFoundException(id, typeof(TEntity));

        #endregion

        #region Private & Protected Methods

        protected virtual IQueryable<TEntity> GetQueryable(bool includeDetails = true)
        {
            if (includeDetails)
                return DbSet;
            else
                return DbSet;
        }

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