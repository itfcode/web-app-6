using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.IconButtons.Base
{
    public abstract class ItfIconButtonBase : MudIconButton
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
            Size = Size.Small;
            Style = "padding:0px;padding-left:4px;";
        }

        #endregion
    }
}
