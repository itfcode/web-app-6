using ITFCodeWA.ClientMudBlazor.Components.IconButtons.Base;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.IconButtons
{
    public abstract class IftCloseIconButton : ItfIconButtonBase
    {
        #region Protected Methods 

        protected override void DefineProperties() 
        {
            base.DefineProperties();

            Color = Color.Secondary;
            Icon = Icons.Filled.Close;
            Title = "Закрыть";
        }

        #endregion
    }
}
