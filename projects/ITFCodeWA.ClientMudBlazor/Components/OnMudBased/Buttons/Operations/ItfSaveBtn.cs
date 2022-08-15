using ITFCodeWA.ClientMudBlazor.Components.Buttons.Base;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Buttons.Operations
{
    public class ItfSaveBtn : ItfButtonBase
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        #endregion

        #region Override Protected Methods

        protected override void DefineProperties()
        {
            base.DefineProperties();
            Color = MudBlazor.Color.Success;
            StartIcon = @Icons.Material.Filled.Save;
        }

        #endregion
    }
}