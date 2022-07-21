using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.Repositories.Base.Interfaces
{
    public interface IRepository<TContext, TEntity, TKey> : IRepositoryCore<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
    }
}
