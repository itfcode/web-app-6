using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents
{
    public abstract class ApiDocumentService<TDocumentModel> : ApiEntityCrudService<TDocumentModel, Guid>, IApiDocumentService<TDocumentModel>
        where TDocumentModel : class, IDocumentModel
    {
        #region Constructor

        public ApiDocumentService(ItfHttpClient httpClient, string route) : base(httpClient, route) { }

        #endregion
    }
}