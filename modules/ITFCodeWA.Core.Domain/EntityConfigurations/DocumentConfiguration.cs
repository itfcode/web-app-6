using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.EntityConfiguration.Base;
using ITFCodeWA.Core.Domain.Extensions;

namespace ITFCodeWA.Core.Domain.EntityConfigurations
{
    public abstract class DocumentConfiguration<TEntity> : EntityConfigurationCore<TEntity, Guid>
        where TEntity : class, IDocument
    {
        #region Public Methods 

        /// <summary>
        /// Sets common configuration settings for Document
        /// </summary>
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(p => p.Number, nameof(IDocument.Number), true)
                .ConfigProperty(p => p.Date, nameof(IDocument.Date), true)
                .ConfigProperty(p => p.Commited, nameof(IDocument.Commited), true)
                .ConfigProperty(p => p.Marked, nameof(IDocument.Marked), true)
                .ConfigProperty(p => p.AuthorId, nameof(IDocument.AuthorId), true)
                .ConfigProperty(p => p.Comment, nameof(IDocument.Comment))
                .AddIndex(i => i.Number, isUnique: true)
                .AddIndex(i => i.Date, isUnique: false)
                .AddIndex(i => i.AuthorId, isUnique: false)
                ;
        }

        #endregion
    }
}