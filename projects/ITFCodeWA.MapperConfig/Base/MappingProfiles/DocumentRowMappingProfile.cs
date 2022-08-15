using ITFCodeWA.Core.Data.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.MapperConfig.Base.MappingProfiles
{
    public abstract class DocumentRowMappingProfile<TEntity, TEntityModel> : EntityMappingProfile<TEntity, TEntityModel>
        where TEntity : class, IDocumentRow
        where TEntityModel : class, IDocumentRowModel
    {
    }
}