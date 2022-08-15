using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ITFCodeWA.Core.Domain.Repositories.References.Interfaces
{
    public interface IReadOnlyReferenceRepository<TEntity> : IReadOnlyRepository<TEntity, int>
        where TEntity : class, IReference
    {
        Task<TEntity> FindByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
        Task<TEntity> GetByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);

        Task<IList<TEntity>> FindAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
        Task<IList<TEntity>> GetAllByNameAsync([NotNull] string name, bool includeDetails = true, CancellationToken cancellationToken = default);
    }
}