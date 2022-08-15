using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base;
using ITFCodeWA.Core.Domain.Repositories.Documents.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.Documents
{
    public class DocumentRepository<TContext, TEntity> : Repository<TContext, TEntity, Guid>,
            IDocumentRepository<TEntity>
        where TContext : DbContext
        where TEntity : class, IDocument
    {
        #region Constructors 

        public DocumentRepository([NotNull] TContext context) : base(context) { }

        #endregion

        #region IDocumentRepository Implementation

        public virtual async Task<TEntity> FindByNumberAsync(int number, bool includeDetails = true, CancellationToken cancellationToken = default)
            => await FindAsync(x => x.Number == number, includeDetails, cancellationToken);

        public virtual async Task<TEntity> GetByNumberAsync(int number, bool includeDetails = true, CancellationToken cancellationToken = default)
             => ValidateFindRequest(await FindByNumberAsync(number, includeDetails, cancellationToken), number, "Number");

        #endregion
    }
}