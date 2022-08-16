using ITFCodeWA.ClientMudBlazor.Components.EntityTableView.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityTableView.Documents.Base
{
    public abstract partial class DocumentTableView<TModel, TApiService> : EntityTableView<TModel, Guid, TApiService>
        where TModel : class, IDocumentModel
        where TApiService : class, IApiDocumentService<TModel>
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
            => await base.OnInitializedAsync();

        #endregion
    }
}