using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Domain.Repositories.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITFCodeWA.Core.Domain.Repositories.References.Interfaces
{
    public interface IReferenceRepository<TContext, TEntity> : IRepository<TContext, TEntity, int>,
            IReadOnlyReferenceRepository<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class, IReference
    {
        //
    }
}