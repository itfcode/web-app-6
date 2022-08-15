using ITFCodeWA.ClientMudBlazor.Services.Api.Base.References;
using ITFCodeWA.ClientMudBlazor.Services.Api.References.Interfaces;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Services.Api.References
{
    public class GoodGroupService : ApiReferenceService<GoodGroupModel>, IGoodGroupService
    {
        #region Constractor

        public GoodGroupService(ItfHttpClient httpClient) : base(httpClient, ApiEndPoints.References.GOOD_GROUPS)
        {
        }

        #endregion
    }
}