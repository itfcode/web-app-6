using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITFCodeWA.Domain.EntityConfigurations.Base
{
    public abstract class DocumentRowConfiguration<TEntity> : EntityConfigurationBase<TEntity, Guid>
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
                .ConfigProperty(p => p.RowNumber, nameof(IDocumentRow.RowNumber), true)
                .AddIndex(i => i.DocumentId, isUnique:false)
                ;
        }

        #endregion
    }
}
