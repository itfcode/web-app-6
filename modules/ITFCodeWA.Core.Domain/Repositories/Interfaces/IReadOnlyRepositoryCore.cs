using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ITFCodeWA.Core.Domain.Repositories.Interfaces
{
    public interface IReadOnlyRepositoryCore<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> FindByIdAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<TEntity> GetByIdAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);
    }
}
