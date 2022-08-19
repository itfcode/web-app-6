using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References.Interfaces;
using ITFCodeWA.Core.Models.Common.References.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Autocomplete.Base
{
    public abstract class ItfAutocompleteBase<TModel, TApiService> : MudAutocomplete<TModel>
        where TModel : class, IReferenceModel
        where TApiService : class, IApiReferenceService<TModel>

    {
        #region Parameters 

        [Inject]
        public TApiService ApiService { get; set; }

        #endregion

        #region Protected Properties 

        protected virtual int SearchingValueMinLength => 3;

        protected virtual string CurrentLabel => "Not Defined";

        protected virtual string SearchArea => "Поиск по названию";

        #endregion

        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            DefineProperties();
            await base.OnInitializedAsync();
        }

        #endregion

        #region Protected Methods 

        protected virtual string GetModelView(TModel model) => (model.Name ?? string.Empty).Trim();

        protected virtual async Task<IEnumerable<TModel>> SearchModelsFunc(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < SearchingValueMinLength)
                return new List<TModel>();

            return await ApiService.FindByValueAsync(value);
        }

        protected virtual async Task OnClearButtonClickHandler(MouseEventArgs args)
        {
            await ValueChanged.InvokeAsync(Activator.CreateInstance<TModel>());
        }

        protected virtual void DefineProperties()
        {
            Adornment = Adornment.End;
            AdornmentColor = Color.Dark;
            AdornmentIcon = Icons.Filled.Search;
            Clearable = true;
            HelperText = $"{SearchArea} (Ведите минимум {SearchingValueMinLength} символа)";
            Label = string.IsNullOrWhiteSpace(Label) ? CurrentLabel : Label;
            OnClearButtonClick = EventCallback.Factory.Create(this, OnClearButtonClickHandler);
            SearchFunc = SearchModelsFunc;
            ToStringFunc = GetModelView;
            Variant = Variant.Text;
        }

        #endregion
    }
}