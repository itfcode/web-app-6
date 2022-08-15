using ITFCodeWA.Core.Data.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.MapperConfig.Base.MappingProfiles
{
    public abstract class ReferenceMappingProfile<TEntity, TEntityModel> : EntityMappingProfile<TEntity, TEntityModel>
        where TEntity : class, IReference
        where TEntityModel : class, IReferenceModel
    {
    }
}