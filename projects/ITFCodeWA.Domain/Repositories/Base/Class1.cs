using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Domain.Repositories.Base
{
    public abstract class Repository<TContext, TEntity, TKey> : IRepository<TContext, TEntity, TKey>
            where TContext : DbContext
            where TEntity : class, IEntity<TKey>
            where TKey : IComparable
    {
        public bool Exist(TKey id) => throw new NotImplementedException();

        public TEntity Add(TEntity entity) => throw new NotImplementedException();

        public TEntity Update(TKey id, Action<TEntity> updater) => throw new NotImplementedException();

        public void Delete(TKey id) => throw new NotImplementedException();

        public void Delete(TEntity entity) => throw new NotImplementedException();

        public void DeleteRange(IEnumerable<TKey> range) => throw new NotImplementedException();

        public void DeleteRange(IEnumerable<TEntity> range) => throw new NotImplementedException();

        public void Save() => throw new NotImplementedException();

        public async Task SaveAsync() => throw new NotImplementedException();
    }
}
