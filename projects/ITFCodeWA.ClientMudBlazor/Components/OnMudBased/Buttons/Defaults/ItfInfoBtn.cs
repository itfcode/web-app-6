using ITFCodeWA.ClientMudBlazor.Components.Buttons.Base;

namespace ITFCodeWA.ClientMudBlazor.Components.Buttons.Defaults
{
    public class ItfInfoBtn : ItfButtonBase
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
            Color = MudBlazor.Color.Info;
        }

        #endregion
    }
}