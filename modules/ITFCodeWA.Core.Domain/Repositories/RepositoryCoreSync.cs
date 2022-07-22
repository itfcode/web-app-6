//using ITFCodeWA.Core.Data.Base.Interface;
//using ITFCodeWA.Core.Domain.Exceptions;
//using ITFCodeWA.Core.Domain.Repositories.Interfaces;
//using Microsoft.EntityFrameworkCore;
//using static ITFCodeWA.Core.Domain.Helpers.ExpressionBuilder;

//namespace ITFCodeWA.Core.Domain.Repositories
//{
//    public abstract partial class RepositoryCore111<TContext, TEntity, TKey> : IRepositoryCore<TContext, TEntity, TKey>
//            where TContext : DbContext
//            where TEntity : class, IEntity<TKey>
//            where TKey : IComparable
//    {
//        #region Sync Methods 

//        public virtual bool Exist(TKey id)
//        {
//            ArgumentNullException.ThrowIfNull(id, nameof(id));

//            return DbSet.Any(GenerateEqual<TEntity>("Id", id));
//        }

//        public virtual TEntity GetById(TKey id)
//        {
//            ArgumentNullException.ThrowIfNull(id, nameof(id));

//            return DbSet.Find(id);
//        }

//        public virtual TEntity Add(TEntity entity)
//        {
//            try
//            {
//                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

//                return DbSet.Add(entity).Entity;
//            }
//            catch (Exception ex)
//            {
//                throw new EntityAddingException(ex);
//            }
//        }

//        public virtual void AddRange(IEnumerable<TEntity> entities)
//        {
//            try
//            {
//                DbSet.AddRange(entities);
//            }
//            catch (Exception ex)
//            {
//                throw new EntityAddingException(ex);
//            }
//        }

//        public virtual TEntity Update(TKey id, Action<TEntity> updater)
//        {
//            try
//            {
//                ArgumentNullException.ThrowIfNull(id, nameof(id));
//                ArgumentNullException.ThrowIfNull(updater, nameof(updater));

//                var entity = GetById(id) ?? throw new EntityNotFoundException(id, typeof(TEntity));

//                updater(entity);

//                Context.Entry(entity).State = EntityState.Modified;

//                return entity;
//            }
//            catch (Exception ex)
//            {
//                throw new EntityUpdatingException(ex);
//            }
//        }

//        public virtual TEntity Update(TEntity entity)
//        {
//            try
//            {
//                ArgumentNullException.ThrowIfNull(entity, nameof(entity));
//                AttachEntity(entity);
//                return DbSet.Update(entity).Entity;
//            }
//            catch (Exception ex)
//            {
//                throw new EntityUpdatingException(ex);
//            }
//        }

//        public virtual void UpdateRange(IEnumerable<TKey> ids) => throw new NotImplementedException();

//        public virtual void UpdateRange(IEnumerable<TEntity> entities) => throw new NotImplementedException();

//        public virtual void Delete(TKey id)
//        {
//            try
//            {
//                ArgumentNullException.ThrowIfNull(id, nameof(id));

//                var entity = GetById(id) ?? throw new NullReferenceException($"Entity '{typeof(TEntity).Name}' with id = {id} not found");

//                Delete(entity);
//            }
//            catch (Exception ex)
//            {
//                throw new EntityDeletingException(ex.Message, ex);
//            }
//        }

//        public virtual void Delete(TEntity entity)
//        {
//            try
//            {
//                ArgumentNullException.ThrowIfNull(entity, nameof(entity));

//                AttachEntity(entity);

//                DbSet.Remove(entity);
//            }
//            catch (Exception ex)
//            {
//                throw new EntityDeletingException(ex.Message, ex);
//            }
//        }

//        public virtual void DeleteRange(IEnumerable<TKey> ids)
//        {

//        }

//        public virtual void DeleteRange(IEnumerable<TEntity> entities)
//        {
//            ArgumentNullException.ThrowIfNull(entities, nameof(entities));

//            AttachEntities(entities);

//            DbSet.RemoveRange(entities);
//        }

//        public virtual int SaveChanges() 
//        {
//            try
//            {
//                return Context.SaveChanges();
//            }
//            catch (Exception ex)
//            {
//                throw new EntityCommitingException(ex);
//            }
//        }

//        #endregion
//    }
//}
