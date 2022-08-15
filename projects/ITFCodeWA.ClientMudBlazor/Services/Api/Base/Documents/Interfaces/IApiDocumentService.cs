using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces
{
    public interface IApiDocumentService<TDocumentModel> : IApiEntityCrudService<TDocumentModel, Guid>
        where TDocumentModel : class, IDocumentModel
    {
    }
}