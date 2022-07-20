using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.Repositories.Base.Interfaces
{
    public interface IRepository<TContext, TEntity, TKey>
        where TContext : DbContext
        where TEntity : class, IEntity<TKey> 
        where TKey : IComparable
    {
        bool Exist(TKey id);

        void Save();

        Task SaveAsync();
    }
}
