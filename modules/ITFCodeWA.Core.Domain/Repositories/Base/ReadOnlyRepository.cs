using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Exceptions;
using ITFCodeWA.Core.Domain.Helpers;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Repositories.Base
{
    public partial class ReadOnlyRepository<TContext, TEntity, TKey> : IReadOnlyRepository<TEntity, TKey>
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

        public ReadOnlyRepository([NotNull] TContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        #endregion

        #region IReadOnlyRepositoryCore implementation

        public async Task<bool> ExistsAsync([NotNull] TKey id, CancellationToken cancellationToken = default)
            => await ExistsAsync(ExpressionFactory.Equal<TEntity>("Id", id), cancellationToken);

        public async Task<bool> ExistsAsync([NotNull] Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
            => await GetQueryable().AnyAsync(predicate, cancellationToken);

        public virtual async Task<TEntity> FindAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await GetQueryableForOne(includeDetails).SingleOrDefaultAsync(predicate, cancellationToken);

        public virtual async Task<TEntity> FindAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(ExpressionFactory.Equal<TEntity>("Id", id), includeDetails, cancellationToken);

        public virtual async Task<TEntity> GetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(predicate, includeDetails, cancellationToken) ?? throw new EntityNotFoundException(typeof(TEntity));

        public virtual async Task<TEntity> GetAsync([NotNull] TKey id, bool includeDetails = true, CancellationToken cancellationToken = default)
            => ValidateFindRequest(await FindAsync(id, includeDetails, cancellationToken), id, "Id");

        public IQueryable<TEntity> GetDBSetQuery()
            => DbSet.AsNoTracking();

        #endregion

        #region Private & Protected Methods

        protected virtual IQueryable<TEntity> GetOneWithDetails()
            => DbSet;

        protected virtual IQueryable<TEntity> GetManyWithDetails()
            => DbSet;

        protected virtual IQueryable<TEntity> GetQueryableForOne(bool includeDetails = true)
            => includeDetails ? GetOneWithDetails() : GetQueryable();

        protected virtual IQueryable<TEntity> GetQueryableForMany(bool includeDetails = true)
            => includeDetails ? GetManyWithDetails() : GetQueryable();

        protected virtual IQueryable<TEntity> GetQueryable() => DbSet;

        protected TEntity ValidateFindRequest(TEntity entity, object paramValue, string paramName)
            => entity ?? throw new EntityNotFoundException(paramValue, paramName, typeof(TEntity));

        protected IList<TEntity> ValidateFindAllRequest(IList<TEntity> entities, object paramValue, string paramName)
            => (entities is not null && entities.Any()) ? entities : throw new EntityNotFoundException(paramValue, paramName, typeof(TEntity));


        #endregion
    }
}