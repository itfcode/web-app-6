using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;

namespace ITFCodeWA.Core.Domain.Repositories.References.Interfaces
{
    public interface IReferenceRepository<TEntity> : IRepository<TEntity, int>,
            IReadOnlyReferenceRepository<TEntity>
        where TEntity : class, IReference
    {
        //
    }
}