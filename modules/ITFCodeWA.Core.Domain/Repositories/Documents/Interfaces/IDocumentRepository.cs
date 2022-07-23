using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Core.Domain.Repositories.Documents.Interfaces
{
    public interface IDocumentRepository<TContext, TEntity> : IRepository<TContext, TEntity, Guid>
        where TContext : DbContext
        where TEntity : class, IDocument
    {
        Task<TEntity> GetByNumberAsync(int number, bool includeDetails = true, CancellationToken cancellationToken = default);
        Task<TEntity> FindByNumberAsync(int number, bool includeDetails = true, CancellationToken cancellationToken = default);
    }
}
