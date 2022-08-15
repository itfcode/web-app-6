using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class FoodGroupService : ApiReferenceService<FoodGroupModel>, IFoodGroupService
    {
        #region Constractor

        public FoodGroupService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.FOOD_GROUPS)
        {
        }

        #endregion
    }
}