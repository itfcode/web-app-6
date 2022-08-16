using ITFCodeWA.ClientMudBlazor.Components.EntityTableView.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityTableView.References.Base
{
    public abstract partial class ReferenceTableView<TModel, TApiService> : EntityTableView<TModel, int, TApiService>
        where TModel : class, IReferenceModel
        where TApiService : class, IApiReferenceService<TModel>
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
            => await base.OnInitializedAsync();

        #endregion
    }
}