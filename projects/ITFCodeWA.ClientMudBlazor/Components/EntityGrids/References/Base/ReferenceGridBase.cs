using ITFCodeWA.ClientMudBlazor.Components.EntityGrids.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityGrids.References.Base
{
    public abstract class ReferenceGridBase<TModel, TApiService, TModelCard> : EntityGridBase<TModel, int, TApiService>
        where TModel : class, IReferenceModel
        where TApiService : class, IApiReferenceService<TModel>
        where TModelCard : ComponentBase
    {
        protected virtual async Task OpenForm(TModel model, string title = default!)
        {
            var parameters = new DialogParameters
            {
                ["ModelId"] = model.Id,
            };

            var options = new DialogOptions() { CloseButton = true, DisableBackdropClick = true };

            var res = await DialogService.Show<TModelCard>(title, parameters, options).Result;

            if (!res.Cancelled)
            {
                var ss = 10;
            }
        }
    }
}
