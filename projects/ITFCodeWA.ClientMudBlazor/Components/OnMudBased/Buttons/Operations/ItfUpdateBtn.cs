using ITFCodeWA.ClientMudBlazor.Components.Buttons.Base;
using System.Threading.Tasks;

namespace ITFCodeWA.ClientMudBlazor.Components.Buttons.Operations
{
    public class ItfUpdateBtn : ItfButtonBase
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
            Color = MudBlazor.Color.Tertiary;
            StartIcon = MudBlazor.@Icons.Material.Filled.Update;
        }

        #endregion
    }
}