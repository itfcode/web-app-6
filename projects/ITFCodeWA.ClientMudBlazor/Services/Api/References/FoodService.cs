using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class FoodService : ApiReferenceService<FoodModel>, IFoodService
    {
        #region Constractor

        public FoodService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.FOODS)
        {
        }

        #endregion
    }
}