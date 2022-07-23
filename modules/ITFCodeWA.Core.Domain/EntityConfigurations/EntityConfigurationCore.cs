using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Core.Domain.EntityConfiguration
{
    public abstract class EntityConfigurationCore<TEntity, TKey> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        #region Private & Protected Fields 

        protected EntityTypeBuilder<TEntity> _builder;

        protected virtual string TableName => typeof(TEntity).Name;

        #endregion

        #region Constructor 

        public virtual void Configure()
        {
            if (_builder is null)
                throw new NullReferenceException(nameof(_builder));

            _builder.Property(d => d.Id)
                .HasColumnName(typeof(TEntity).Name + "Id");

            SimpleLogger.Log($"Table name should be '{TableName}'");
            _builder.ToTable(TableName);
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            SimpleLogger.Log($"Start entity configuration for type {typeof(TEntity).Name}");

            _builder = builder;

            Configure();

            SimpleLogger.Log($"End entity configuration for type {typeof(TEntity).Name}");
        }

        #endregion
    }
}
