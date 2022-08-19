using ITFCodeWA.ClientMudBlazor.Components.Autocomplete.Base;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Components.OnMudBased.Autocomplete
{
    public partial class FoodGroupAutoComplete : ItfAutocompleteBase<FoodGroupModel, IFoodGroupService>
    {
        #region Protected Properties 

        protected override string CurrentLabel => "Группа продуктов питания";

        #endregion

        #region Protected Methods 

        #endregion
    }
}
