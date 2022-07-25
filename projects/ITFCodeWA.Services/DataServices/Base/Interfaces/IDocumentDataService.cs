using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.Services.DataServices.Base.Interfaces
{
    public interface IDocumentDataService<TEntityModel> : IDataService<TEntityModel, Guid>
        where TEntityModel : class, IDocumentModel
    {
    }
}