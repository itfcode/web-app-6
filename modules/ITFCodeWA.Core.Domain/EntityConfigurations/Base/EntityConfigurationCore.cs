using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Core.Domain.EntityConfiguration.Base
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
                .HasColumnName(typeof(TEntity).Name + "Id")
                .HasColumnOrder(0);

            _builder.ToTable(TableName);
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _builder = builder;

            Configure();
        }

        #endregion
    }
}
