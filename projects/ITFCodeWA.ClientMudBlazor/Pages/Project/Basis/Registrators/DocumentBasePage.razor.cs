using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Pages.Project.Basis.Registrators
{
    public abstract partial class DocumentBasePage<TModel, TApiService> : EntityTableBasePage<TModel, Guid, TApiService>
        where TModel : class, IDocumentModel
        where TApiService : class, IApiDocumentService<TModel>
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        #endregion
    }
}