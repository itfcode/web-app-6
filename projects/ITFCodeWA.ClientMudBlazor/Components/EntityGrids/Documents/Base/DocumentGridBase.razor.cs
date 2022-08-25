using ITFCodeWA.ClientMudBlazor.Components.EntityGrids.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Documents.Interfaces;
using ITFCodeWA.Core.Models.Common.Documents.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityGrids.Documents.Base
{
    public partial class DocumentGridBase<TModel, TApiService, TModelCard> : EntityGridBase<TModel, Guid, TApiService>
        where TModel : class, IDocumentModel
        where TApiService : class, IApiDocumentService<TModel>
        where TModelCard : ComponentBase
    {
        protected string _toolBarLabel = "ToolBarLabel not defined";
        protected string _relatedInfo = "RelatedInfo not defined";

        protected override void InitColumns() { }

        protected virtual async Task OpenForm(TModel model, string title = default!)
        {
            var parameters = new DialogParameters
            {
                ["ModelId"] = model is not null ? model.Id : default(Guid),
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