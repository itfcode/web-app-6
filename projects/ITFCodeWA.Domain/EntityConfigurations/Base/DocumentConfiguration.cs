using ITFCodeWA.Core.Data.Base.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Domain.EntityConfigurations.Base
{
    public abstract class DocumentConfiguration<TEntity> : EntityConfigurationBase<TEntity, Guid>
        where TEntity : class, IEntitySync
    {
        #region Public Methods 

        public override void Configure()
        {
            base.Configure();
        }

        public override sealed void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }

        #endregion
    }
}
