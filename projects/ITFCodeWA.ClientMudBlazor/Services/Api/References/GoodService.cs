using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class GoodService : ApiReferenceService<GoodModel>, IGoodService
    {
        #region Constractor

        public GoodService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.GOODS)
        {
        }

        #endregion
    }
}