using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.Buttons.Base
{
    public abstract class ItfButtonBase : MudButton
    {
        #region Initialization

        protected override async Task OnInitializedAsync()
        {
            DefineProperties();
            await base.OnInitializedAsync();
        }

        #endregion

        #region Virtual Protected Methods 

        protected virtual void DefineProperties()
        {
            Size = Size.Small;
            //Variant = Variant.Outlined;
            Variant = Variant.Filled;
            Style = "min-width:95px;";
        }

        #endregion
    }
}