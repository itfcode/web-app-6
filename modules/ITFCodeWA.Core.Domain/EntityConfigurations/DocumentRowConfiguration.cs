using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Core.Domain.EntityConfigurations
{
    public abstract class DocumentRowConfiguration<TEntity> : EntityConfigurationCore<TEntity, Guid>
        where TEntity : class, IDocumentRow
    {
        #region Public Methods 

        /// <summary>
        /// Sets common configuration settings for Document Row 
        /// </summary>
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.DocumentId, nameof(IDocumentRow.DocumentId), true)
                .ConfigProperty(p => p.RowNumber, nameof(IDocumentRow.RowNumber), true)
                .AddIndex(i => i.DocumentId, isUnique: false)
                ;
        }

        #endregion
    }
}