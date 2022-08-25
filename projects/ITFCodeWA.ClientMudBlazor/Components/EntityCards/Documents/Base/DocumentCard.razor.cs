using ITFCodeWA.ClientMudBlazor.Components.EntityCards.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityCards.Documents.Base
{
    public partial class DocumentCard<TModel, TApiService> : EntityCardBase<TModel, Guid, TApiService>
        where TModel : class, IDocumentModel, new()
        where TApiService : class, IApiDocumentService<TModel>
    {
    }
}