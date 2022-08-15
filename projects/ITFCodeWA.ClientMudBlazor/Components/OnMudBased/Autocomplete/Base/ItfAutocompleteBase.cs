using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Autocomplete.Base
{
    public abstract class ItfAutocompleteBase<TModel> : MudAutocomplete<TModel>
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            DefineProperties();
            await base.OnInitializedAsync();
        }

        #endregion

        #region Protected Methods 

        protected virtual void DefineProperties()
        {
        }

        #endregion
    }
}