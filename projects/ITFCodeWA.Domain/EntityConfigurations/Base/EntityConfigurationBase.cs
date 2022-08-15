using ITFCodeWA.Core.Data.Base.Interface;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Domain.EntityConfigurations.Base
{
    public abstract class EntityConfigurationBase<TEntity, TKey> : EntityConfigurationCore<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable
    {
        /// <summary>
        ///     Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public override sealed void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}
