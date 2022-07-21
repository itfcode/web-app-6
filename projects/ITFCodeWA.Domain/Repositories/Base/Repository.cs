using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Repositories;
using ITFCodeWA.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.Repositories.Base
{
    public abstract class Repository<TContext, TEntity, TKey> : RepositoryCore<TContext, TEntity, TKey>, IRepository<TContext, TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        #region Constructros 

        public Repository(TContext context) : base(context) { }

        #endregion

    }
}
