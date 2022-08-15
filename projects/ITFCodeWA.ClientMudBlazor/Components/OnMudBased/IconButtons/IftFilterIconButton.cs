using ITFCodeWA.ClientMudBlazor.Components.IconButtons.Base;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.IconButtons
{
    public abstract class IftFilterIconButton : ItfIconButtonBase
    {
        #region Protected Methods 

        protected override void DefineProperties() 
        {
            base.DefineProperties();

            Color = Color.Default;
            Icon = Icons.Filled.FilterAlt;
            Title = "Фильтр";
        }

        #endregion
    }
}
