using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Core.Domain.EntityConfigurations.Base
{
    public abstract class ReferenceConfiguration<TEntity> : EntityConfigurationCore<TEntity, int>
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
                .ConfigProperty(p => p.Comment, nameof(IReference.Comment))
                .AddIndex(i => i.Name, isUnique: true);
        }

        #endregion
    }
}