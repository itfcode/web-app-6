using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Domain.EntityConfigurations.Base
{
    public abstract class ReferenceConfiguration<TEntity> : EntityConfigurationBase<TEntity, int>
        where TEntity : class, IReference
    {
        #region Public Methods 

        /// <summary>
        /// Sets common configuration settings for references 
        /// </summary>
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.Name, nameof(IReference.Name), true, 99)
                .AddIndex(i => i.Name, isUnique: true)
                .ConfigProperty(p => p.Comment, nameof(IReference.Comment));
        }

        #endregion
    }
}
