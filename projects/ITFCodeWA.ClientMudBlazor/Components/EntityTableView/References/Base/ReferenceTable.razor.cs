using ITFCodeWA.Core.Models.Common.References.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityTableView.References.Base
{
    public partial class ReferenceTable<TModel, TModelForm> : ComponentBase
        where TModel : class, IReferenceModel
        where TModelForm : ComponentBase
    {
        #region Protected Properties 

        protected virtual async Task OpenForm(TModel model, string title = default!)
        {
            var parameters = new DialogParameters
            {
                ["ModelId"] = model.Id,
                //["SaveHandler"] = EventCallback.Factory.Create(this, (TModel arg) => Save(arg)),
            };

            var options = new DialogOptions() { CloseButton = true };

            await DialogService.Show<TModelForm>(title, parameters, options).Result;
        }

        #endregion
    }
}