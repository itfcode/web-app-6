using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Core.Domain.EntityConfigurations
{
    public abstract class ReferenceConfiguration<TEntity> : EntityConfigurationCore<TEntity, int>
        where TEntity : class, IReference
    {
        #region Protected Properties 

        protected virtual int ColumnNameLenth => 99;

        protected virtual int? ColumnCommentLenth => default;

        #endregion

        #region Public Methods 

        /// <summary>
        /// Sets common configuration settings for references 
        /// </summary>
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.Name, nameof(IReference.Name), true, ColumnNameLenth, columnOrder: 1)
                .ConfigProperty(p => p.Comment, nameof(IReference.Comment), maxLength: ColumnCommentLenth)
                .AddIndex(i => i.Name, isUnique: true);
        }

        #endregion
    }
}