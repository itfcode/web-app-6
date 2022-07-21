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

        #region Private & Protected Methods

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